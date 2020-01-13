using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorDemo_Cars
{
    //Audi is a car. Relationship 'is a'
    class Audi :Car
    {
        private string brand = "Audi";
        //property
        protected string Model { get; set; }
        public Audi(int hp, string brand, string model):base(hp,brand)
        {
            this.Model = model;
        }
        public new void showDetails()
        {
            Console.WriteLine("Brand: {0} \t HP: {1} \t Colour: {2} ", brand, HP, colour);
        }

        public override void Repair()
        {
            Console.WriteLine("Audi {0} was repaired", Model);
        }
    }
}
