using System;

namespace Enumeration
{
    enum DayOfWeek { Mon = 2, Tue, Wed, Thurs, Fri, Sat, Sun};//index is increased from initial by 1
    //enum type can have same values
    enum vowels { a=1,e,i=1,o,u}
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)DayOfWeek.Wed);//returns 3
            Console.WriteLine(DayOfWeek.Mon);//returns Mon
            Console.WriteLine((int) vowels.a);//returns 1
            Console.WriteLine((int)vowels.o);// returns 2
            Console.WriteLine("...................................................\n");

            //finding number of values in enum
            string[] values = Enum.GetNames(typeof(vowels));
            int total = 0;
            foreach(string v in values)
            {
                total++;
            }
            Console.WriteLine("Number of values in vowels enum is {0}", total);
        }
    }
}
