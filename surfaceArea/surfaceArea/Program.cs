using System;

namespace surfaceArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculates the area of a rectangle using a class");
            Console.Write("Enter length of rectangle: ");
            double len = double.Parse(Console.ReadLine());
            Console.Write("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Surface one = new Surface(len, width);
            Console.WriteLine("Length: {0}", one.Length);
            Console.WriteLine("Width: {0}", one.Width);
            one.Area();

            Console.ReadKey();
        }
    }
}
