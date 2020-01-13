using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorDemo_Cars
{
    class Car
    {
        //properties
        protected int HP { get; set; }
        protected string colour { get; set; }

        //has a relationship
        protected CarInfo carId = new CarInfo();
        
        public void setCarInfo(int iD, string owner)
        {
            CarInfo.ID = iD;
            CarInfo.Owner = owner;
        }

        public void getCarInfo()
        {
            Console.WriteLine("Car ID: {0} \nCar Owner: {1}", CarInfo.ID, CarInfo.Owner);
        }

        //default constructor
        public Car(){
            HP = 250;
            colour = "red";
        }

        //constructor
        public Car(int hp, string col)
        {
            this.HP = hp;
            this.colour = col;
        }

        public void showDetails()
        {
            Console.WriteLine("HP: {0} \t Colour: {1} ",HP,colour);
        }

        public virtual void Repair() //virtual allows overide. Opposite is sealed which doesn't allow further inheritance
        {
            Console.WriteLine("Car was repaired");
        }
    }
}
