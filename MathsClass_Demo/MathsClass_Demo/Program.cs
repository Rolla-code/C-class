using System;

namespace MathsClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter first nummber: ");
            double num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second nummber: ");
            double num2 = Double.Parse(Console.ReadLine());
            double num3 = -num1; 
            // Ceil - to next whole number       Floor - to lesser whole number
            Console.WriteLine("Num1: "+num1 + "\t\t\t\tNum2: " + num2 + "\nNum1 Ceiled: "+ Math.Ceiling(num1) +
                "\t\t\t\tNum2 Floored: " + Math.Floor(num2));

            Console.WriteLine("Higher of {0} and {1} is {2}", num1,num2, Math.Max(num1,num2));
            Console.WriteLine("Lower of {0} and {1} is {2}", num1, num2, Math.Min(num1, num2));
            Console.WriteLine("{0} to the power {1} is {2}", num1, num2, Math.Pow(num1, num2));
            Console.WriteLine("Square root of {0} is {1}", num1, Math.Sqrt(num1));
            Console.WriteLine("Square root of {0} is {1}", num2, Math.Sqrt(num2));
            Console.WriteLine("Value of pi is {0}", Math.PI);
            Console.WriteLine("The absolute of {0} is {1}", num3, Math.Abs(num3));
        }
    }
}
