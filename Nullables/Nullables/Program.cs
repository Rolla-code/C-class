using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 12345;

            double? num3 = new Double?();
            double? num4 = 6.789;

            bool? boolVal = new bool?();
            Console.WriteLine("The nullable numbers are {0} \t {1} \t {2} \t{3}", num1, num2,num3,num4);
            Console.WriteLine("The boolean value is {0}", boolVal);

            bool? isMale = null;
            if (isMale == true)
            {
                Console.WriteLine("User is male");
            }
            else if(isMale == false){
                Console.WriteLine("User is female");
            }
            else
            {
                Console.WriteLine("No gender selected");
            }

            double num5;
            if (num4 == null)
            {
                num5 = 0.0;
            }
            else
            {
                num5 = (double)num4;
            }

            Console.WriteLine("Value of num 5 is: {0}", num5);

            //The null coalescing operator
            num5 = num1 ?? 987; //assigns 987 to num5 only if num1 is null
            Console.WriteLine("Value of num 5 is: {0}", num5);
            num5 = num2 ?? 987; //assigns 987 to num5 only if num2 is null
            Console.WriteLine("Value of num 5 is: {0}", num5);

        }
    }
}
