using System;
using System.IO;

namespace ReadAndWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            readFromFile();
            writeToFile();
        }

        public static void readFromFile()
        {
            string myText = System.IO.File.ReadAllText(@"C:\Users\Rolland\Desktop\ME.txt");
            Console.WriteLine("Contents of ME.txt file \n {0}", myText);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Rolland\Desktop\ME.txt");
            Console.WriteLine("\nContents of ME.txt file");
            int counter = 1;
            foreach (string line in lines)
            {
                Console.WriteLine(counter + ". " + line);
                counter++;
            }
        }

        public static void writeToFile()
        {
            // Creating different lines of text in file 
            string[] lines = { "I'm cool with Java", "Also cool with C++", "C# is a darling" };
            File.WriteAllLines(@"C:\Users\Rolland\Desktop\ME2.txt", lines);

            /*//creating your filename and text in console
            Console.WriteLine("\nPlease enter file name");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the contents of your file");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Rolland\Desktop\" + fileName + ".txt", input);*/

            //using StreamWriter
            using(StreamWriter file = new StreamWriter(@"C:\Users\Rolland\Desktop\ME4.txt"))
            {
                foreach(string line in lines)
                {
                    if (line.Contains("i"))
                    {
                        file.WriteLine(line);
                    }
                }
            }

            using (StreamWriter file = new StreamWriter(@"C:\Users\Rolland\Desktop\ME4.txt", true))
            {
                file.WriteLine("New line of text added");
            }

        }
    }
}
