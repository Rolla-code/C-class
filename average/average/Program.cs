using System;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "0";
            int counter = 0, pos = 1;
            double total = 0, currentNum, average;
            Console.WriteLine("This application calculates average of positive numbers");
            while (input != "-1")
            {
                Console.WriteLine("Please enter score {0}. Enter -1 to calculate average", pos);
                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------------------------");
                    average = total / counter;
                    Console.WriteLine("Average of the {0} numbers: {1}", counter, average);
                }
                //checking input
                if (double.TryParse(input, out currentNum) && currentNum >= 0)
                {
                    total += currentNum;
                }
                else
                {
                    if (!input.Equals("-1"))
                    {
                        Console.WriteLine("Please enter a positive number");
                    }
                    continue;
                }
                counter++;
                pos++;
            }
        }
    }
}
