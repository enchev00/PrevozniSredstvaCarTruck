// See https://aka.ms/new-console-template for more information
using PrevozniSredstva;



Car bmw = new Car();
Truck volvo = new Truck();
String stopword = "stop";
double climaCar = 0.9;
double climaTruck = 1.6;
string[] carInput = Console.ReadLine().Split(" ").ToArray();


bmw.CarName = carInput[0];
bmw.Fuel = double.Parse(carInput[1]);
bmw.FuelConsumption = double.Parse(carInput[2]) + climaCar;




string[] truckInput = Console.ReadLine().Split(" ").ToArray();

volvo.TruckName = truckInput[0];
volvo.Fuel = double.Parse(truckInput[1]);
volvo.FuelConsumption = double.Parse(truckInput[2]) + climaTruck;


int broiKomandi = int.Parse(Console.ReadLine());

do
{

    for (int i = 0; i < broiKomandi; i++)
    {
        string[] komandi = Console.ReadLine().Split(" ").ToArray();
        if (komandi[0] == "Drive")
        {

            if (komandi[1] == "Car")
            {
                double distanceAvailableCar;
                double izrazhodenoCar;
                distanceAvailableCar = bmw.Fuel * bmw.FuelConsumption;
                if (distanceAvailableCar > double.Parse(komandi[2]))
                {
                    izrazhodenoCar = bmw.FuelConsumption * double.Parse(komandi[2]);

                    bmw.driveCar(double.Parse(komandi[2]));
                    bmw.Fuel = bmw.Fuel - izrazhodenoCar;

                }
                else
                {
                    Console.WriteLine("Car needs refueling");
                }
            }

            if (komandi[1] == "Truck")
            {

                double distanceAvailableTruck;
                double izrazhodenoTruck;
                distanceAvailableTruck = volvo.Fuel * volvo.FuelConsumption;
                if (distanceAvailableTruck > double.Parse(komandi[2]))
                {
                    izrazhodenoTruck = volvo.FuelConsumption * double.Parse(komandi[2]);

                    volvo.driveTruck(double.Parse(komandi[2]));
                    volvo.Fuel = volvo.Fuel - izrazhodenoTruck;

                }
                else
                {
                    Console.WriteLine("Truck needs refueling");
                }
            }



        }

        if (komandi[0] == "Refuel")
        {
            if (komandi[1] == "Car")
            {
                bmw.Fuel = bmw.Fuel + double.Parse(komandi[2]);
            }
            else if (komandi[1] == "Truck")
            {
                volvo.Fuel = volvo.Fuel + double.Parse(komandi[2]);
                volvo.Fuel = 0.95 * volvo.Fuel;
            }
        }



       


    }


} while (false);


Console.WriteLine("Car: " + Math.Round(bmw.Fuel, 2));
Console.WriteLine("Truck: " + Math.Round(volvo.Fuel, 2));