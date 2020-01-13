using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Employees
{
    class Boss : Employee
    {
        //property
        protected string CompanyCar { get; set; }

        //constructor
        public Boss(string compCar, string name, string fName, double salary):base(name, fName, salary )
        {
            this.CompanyCar = compCar;
        }

        //method
        public void Lead(){
            Console.WriteLine("I am {0} {1} and I'm the boss", FirstName, Name);
        }
    }
}
