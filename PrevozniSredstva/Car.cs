using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Car
    {
        public Car ()
        {

            }
        public String CarName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption  { get; set;}

        double distanceRemaining;

        public void driveCar(double distanceTravelled)
        {

            Console.WriteLine(CarName + " travelled " + distanceTravelled + " km");
            this.Fuel = Fuel; 
            this.FuelConsumption = FuelConsumption;
            
            
        }

        public void printDetails()
        {
            Console.WriteLine("Car Name is: " +CarName + " ,has " + Fuel + " and its fuel consumption is " + FuelConsumption);
        }
        public void fuelCar()
        {
            
        }
    }
}
