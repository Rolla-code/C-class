using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Employees
{
    class Employee
    {
        //properties
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected double Salary { get; set; }

        //default constructor
        public Employee()
        {
            Name = "Doe";
            FirstName = "John";
            Salary = 2500;
        }
        //instantiated constructor
        public Employee(string name, string fName, double salary)
        {
            this.Name = name;
            this.FirstName = fName;
            this.Salary = salary;
        }
        //methods
        public void Work()
        {
            Console.WriteLine("I am currently working");
        }

        public void Pause()
        {
            Console.WriteLine("I am on break at the moment");
        }
    }
}
