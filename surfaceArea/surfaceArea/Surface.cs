using System;
using System.Collections.Generic;
using System.Text;

namespace surfaceArea
{
    class Surface
    {
        private double length, width, surfaceArea;
        
        public Surface(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Length //length property
        {
            get => length;
        }

        public double Width //width property
        {
            get => width;
        }

        public void Area()
        {
            Console.WriteLine("The area of surface of length {0} and width {1} is {2}", length, width, surfaceArea = length * width);
        }
    }
}
