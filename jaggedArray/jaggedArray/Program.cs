using System;

namespace jaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] JFam = new string [3]{ "Joe", "Jake", "Judith" };
            string[] GFam = new string[3] { "Grace", "Gerald", "Gladys" };
            string[] RFam = new string[3] { "Roselyn", "Rita", "Rachael" };
            string[] CFam = new string[3] { "Clara", "Cornell", "Chris" };

            string[][] friend = new string[4][] {
                JFam,GFam,RFam,CFam
            };
            
            for(int i = 0; i < friend.Length; i++)
            {
                Console.WriteLine("Family {0}", ++i);
                --i;
                for (int j = 0; j < friend[i].Length; j++)
                {
                    Console.Write(friend[i][j] + "\t\t");
                }
                Console.WriteLine();
            }
        }
    }
}
