using System;
using System.Collections.Generic;

namespace LambdaProg
{
    class Program
    {
        //lambda expression format
        //parameters => expression/statement block

        public delegate double MathOp(double i);
        public delegate bool Compare(double i, Number num);
        static void Main(string[] args)
        {
            performOP();
        }

        public static void performOP()
        {
            MathOp squareOp = new MathOp(Square);
            squareOp(5);

            Console.WriteLine("\n Odd numbers");
            //complex
            List<int> list = new List<int> { 1,2,3,4,5,6,7, 8,9,10};
            List<int> oddNums = list.FindAll(delegate (int i)
            {
                return (i % 2 == 1);
                }
            );

            foreach(int odd in oddNums)
            {
                Console.WriteLine(odd);
            }

            Console.WriteLine("\n Even numbers");
            //simple
            List<int> evenNums = list.FindAll(j => j%2 == 0);
            evenNums.ForEach(j => Console.WriteLine(j));

            Console.WriteLine();
            Compare comp = (k, n) => k == n.num;
            Console.WriteLine(comp(5, new Number { num = 6}));

        }

        public static double Add(double a, double b){
            return a + b;
        }

        public static double Square(double a)
        {
            double sq = a * a;
            Console.WriteLine("The square of {0} is {1} \n", a, sq);
            return sq;
        }

        public static double TimesTen(double a)
        {
            return a * 10;
        }
    }

}
