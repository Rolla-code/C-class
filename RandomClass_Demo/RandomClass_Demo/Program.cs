using System;

namespace RandomClass_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string again = "0";
            while (again != "-1")
            {
                Console.WriteLine("----------- Welcome to fortune teller -----------");
                Console.WriteLine("Please enter your question");
                Console.ReadLine();
                Random ans = new Random();
                int ansNum = ans.Next(1, 4);
                switch (ansNum)
                {
                    case 1:
                        Console.WriteLine("Yes");
                        break;
                    case 2:
                        Console.WriteLine("No");
                        break;
                    default:
                        Console.WriteLine("Maybe");
                        break;
                }
                Console.WriteLine("Press -1 to exit else continue");
                again = Console.ReadLine();
            }
        }
    }
}
