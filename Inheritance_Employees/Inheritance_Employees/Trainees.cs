using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Employees 
{
    class Trainees : Employee
    {
        //properties
        protected int WorkingHours { get; set; }
        protected int SchoolHours { get; set; }
        
        //constructor
        public Trainees(int workHour, int schoolHour, string name, string fName, double salary): base(name, fName,salary)
        {
            this.WorkingHours = workHour;
            this.SchoolHours = schoolHour;
        }
        
        //method
        public void Learn()
        {
            Console.WriteLine("I learn for {0} hours daily", SchoolHours);
        }
        
        public new void Work()
        {
            Console.WriteLine("I work for {0} hours daily", WorkingHours);
        }
    }
}
