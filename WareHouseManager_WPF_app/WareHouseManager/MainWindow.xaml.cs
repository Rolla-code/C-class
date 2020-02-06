using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WareHouseManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["WareHouseManager.Properties.Settings.CSharpTutDBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            ShowWarehouse();
            ShowStock();
        }

        private void ShowWarehouse()
        {
            try
            {
                string query = "Select * from Warehouse";
                //SqlDataAdapter - interface to make tables usable by C# object
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable WhTable = new DataTable();

                    sqlDataAdapter.Fill(WhTable);

                    //info in datatable to be shown in listbox
                    WhList.DisplayMemberPath = "Location";
                    //item to be delivered when an item from listbox is selected
                    WhList.SelectedValuePath = "Id";
                    //reference to data listbox should populate
                    WhList.ItemsSource = WhTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
           
        }

        private void ShowStock()
        {
            try
            {
                string query = "Select * from Stock";
                //SqlDataAdapter - interface to make tables usable by C# object
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable StockTable = new DataTable();

                    sqlDataAdapter.Fill(StockTable);

                    //info in datatable to be shown in listbox
                    ListStock.DisplayMemberPath = "Name";
                    //item to be delivered when an item from listbox is selected
                    ListStock.SelectedValuePath = "Id";
                    //reference to data listbox should populate
                    ListStock.ItemsSource = StockTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void ShowAssociatedStock()
        {
            try
            {
                string query = "Select * from Stock s inner join WarehouseStock ws on " +
                    "s.Id = ws.StockId where ws.WarehouseId = @WarehouseId";//@WarehouseId is a variable
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //SqlDataAdapter - interface to make tables usable by C# object
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@WarehouseId", WhList.SelectedValue);

                    DataTable StockTable = new DataTable();

                    sqlDataAdapter.Fill(StockTable);

                    //info in datatable to be shown in listbox
                    ListAS.DisplayMemberPath = "Name";
                    //item to be delivered when an item from listbox is selected
                    ListAS.SelectedValuePath = "Id";
                    //reference to data listbox should populate
                    ListAS.ItemsSource = StockTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }

        }

        private void ShowSelectedWarehouseInTextBox()
        {
            try
            {
                string query = "Select Location from Warehouse where id = @WarehouseId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //SqlDataAdapter - interface to make tables usable by C# object
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@WarehouseId", WhList.SelectedValue);

                    DataTable WhDataTable = new DataTable();

                    sqlDataAdapter.Fill(WhDataTable);

                    myTextbox.Text = WhDataTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }

        private void ShowSelectedStockInTextBox()
        {
            try
            {
                string query = "Select Name from Stock where id = @StockId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                //SqlDataAdapter - interface to make tables usable by C# object
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@StockId", ListStock.SelectedValue);

                    DataTable StockDataTable = new DataTable();

                    sqlDataAdapter.Fill(StockDataTable);

                    myTextbox.Text = StockDataTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
            }
        }
        private void WhList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAssociatedStock();
            ShowSelectedWarehouseInTextBox();
        }

        private void DeleteWh_Click(object sender, RoutedEventArgs e)
        {
            try{
                string query = "delete from Warehouse where id = @WarehouseId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@WarehouseId", WhList.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch 
            {
                MessageBox.Show("Please select Warehouse to be deleted");
            }
            finally{
                sqlConnection.Close();
                ShowWarehouse();
            }             
        }

        private void AddWh_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Warehouse values (@Location)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", myTextbox.Text);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowWarehouse();
            }
        }

        private void AddStockToWH_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "Insert into WarehouseStock values (@WarehouseId,@StockId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@WarehouseId", WhList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@StockId", ListStock.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch 
            {
                MessageBox.Show("Please select Warehouse for which stock is to be added");
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedStock();
            }
        }

        private void RemoveStock_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "Delete from WarehouseStock where StockId = @Id and WarehouseId = @WId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@WId", WhList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Id", ListAS.SelectedValue);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Stock Successfully Removed From Warehouse");
            }
            catch
            {
                MessageBox.Show("Please select Associated Stock to be removed");
            }
            finally
            {
                sqlConnection.Close();
                ShowAssociatedStock();
            }
        }

        private void AddNewStock_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Stock values (@Name)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", myTextbox.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Stock Successfully added");
            }
            catch 
            {
                MessageBox.Show("Please type in Stock to be added");
            }
            finally
            {
                sqlConnection.Close();
                ShowStock();
            }
        }

        private void UpdateStock_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "Update Stock set Name = @Name where Id = @StockId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@StockId", ListStock.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Name", myTextbox.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Stock Successfully Updated");
            }
            catch
            {
                MessageBox.Show("Please select Stock to be updated");
            }
            finally
            {
                sqlConnection.Close();
                ShowStock();
            }
        }

        private void DeleteStock_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Stock where id = @StockId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@StockId", ListStock.SelectedValue);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Stock Successfully deleted");
            }
            catch
            {
                MessageBox.Show("Please select Stock to be deleted");
            }
            finally
            {
                sqlConnection.Close();
                ShowStock();
            }
        }

        private void UpdateWarehouseClick(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "Update Warehouse set Location = @Location where Id = @WarehouseId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@WarehouseId", WhList.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@Location", myTextbox.Text);
                sqlCommand.ExecuteScalar();
                MessageBox.Show("Warehouse Successfully Updated");
            }
            catch 
            {
                MessageBox.Show("Please select Warehouse to be updated");
            }
            finally
            {
                sqlConnection.Close();
                ShowWarehouse();
            }
        }

        private void StockList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowSelectedStockInTextBox();
        }
    }
}
