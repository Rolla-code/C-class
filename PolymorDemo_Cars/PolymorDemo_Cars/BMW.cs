using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorDemo_Cars
{
    //BMW is a car. Relationship 'is a'
    class BMW:Car
    {
        private string brand = "BMW";
        //property
        protected string Model { get; set; }
        public BMW(int hp, string colour, string model):base(hp,colour)
        {
            this.Model = model;
        }
        public new void showDetails()
        {
            Console.WriteLine("Brand: {0} \t HP: {1} \t Colour: {2} ",brand, HP, colour);
        }

        public sealed override void Repair() //any class inheriting from BMW overridden method Repair results in error
        {
            Console.WriteLine("BMW {0} was repaired",Model);
        }
    }
}
