 using System;

namespace Inheritance_Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee();
            joe.Work();
            joe.Pause();

            Boss me = new Boss("Hyundai","Wiley", "Stones", 5000 );
            me.Lead();

            Trainees intern = new Trainees(4,2, "Smith", "Judith", 1500);
            intern.Learn();
            intern.Work();
        }
    }
}
