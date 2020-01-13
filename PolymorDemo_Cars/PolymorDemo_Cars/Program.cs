using System;
using System.Collections.Generic;

namespace PolymorDemo_Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new BMW(300,"Blue","X4"),
            new Audi(250,"Black","A3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            Car aud = new Car(220, "Black");
            aud.showDetails();
            aud.setCarInfo(1234, "Code Paradise");
            aud.getCarInfo();

            BMW x = new BMW(240, "Ash", "X3");
            x.showDetails();
            x.setCarInfo(4321, "TecRo");
            x.getCarInfo();

            Car xx = (Car)x;
            xx.showDetails();
        }
    }
}
