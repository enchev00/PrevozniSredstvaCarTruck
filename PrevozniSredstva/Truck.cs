using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Truck
    {

        public Truck() { }

        public String TruckName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }


        public void driveTruck(double distanceTravelled)
        {

            Console.WriteLine(TruckName + " travelled " + distanceTravelled + " km");
            this.Fuel = Fuel;
            this.FuelConsumption = FuelConsumption;


        }
    }
}
