using System;

namespace regAndLog
{
    class Program
    {
        static string userName, password;
        static void Main(string[] args)
        {
            Register();
            logIn();
            Console.Read();
        }

        public static void Register()
        {
            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.WriteLine("Enter password");
            password = Console.ReadLine();
            Console.WriteLine("**********Registration Successful**********\n");
        }
        public static void logIn()
        {
            Console.WriteLine("Enter username");
            if(userName == Console.ReadLine())
            {
                Console.WriteLine("Enter password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("**********Logged in Successfully**********\n");
                }
                else
                {
                    Console.WriteLine("The password you entered was incorrect");
                }
            }
            else
            {
                Console.WriteLine("The username you entered was incorrect.");
            } 
        }
    }
}
