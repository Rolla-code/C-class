using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotifyPropertyChanged_Demo
{
   public class Multiply : INotifyPropertyChanged
    {
        private string num1, num2, result;

        //properties
        public string Num1 {
            get { return num1; }
            set {
                double num;
                bool res = double.TryParse(value, out num);
                if (res) num1 = value;
                OnPropertyChanged("Num1");
                OnPropertyChanged("Result");
            }
        }

        public string Num2
        {
            get { return num2; }
            set
            {
                double num;
                bool res = double.TryParse(value, out num);
                if (res) num2 = value;
                OnPropertyChanged("Num2");
                OnPropertyChanged("Result");
            }
        }

        public string Result
        {
            get {
                double reslt = double.Parse(Num1) * double.Parse(Num2);
                return reslt.ToString();
            }
            set
            {
                double reslt = double.Parse(Num1) * double.Parse(Num2);
                result = reslt.ToString();
                OnPropertyChanged("Result");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
