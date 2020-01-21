using System;

namespace Struct
{
    //Structs are similar to classes - differences exist though
    //Structs do not support inheritance
    // are value types
    // are passed by value
    //cannot have a null reference - does not support default constructor

    public struct Employee
    {
        // member variables
        public string empName, empYearOfEmployment, empPosition;
        public double empSalary;

        //initialized constructor. Default constructor results in error
        public Employee(string name, double salary, string yearOfEmp, string pos)
        {
            this.empName = name;
            this.empSalary = salary;
            this.empYearOfEmployment = yearOfEmp;
            this.empPosition = pos;
        }

        //member function
        public void dispEmpDetails()
        {
            Console.WriteLine("Employee name: {0} \nEmployee salary: {1} \nEmployee Position: {2} " +
                "\nYear of Employment: {3}", empName, empSalary, empPosition, empSalary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee("Rolla-code",2500,"2020","Junior Developer");
            one.dispEmpDetails();

            //changing emp name
            one.empName = "Rolland";
            Console.WriteLine("............................................\nUpdated Name ");
            one.dispEmpDetails();
        }
    }
}
