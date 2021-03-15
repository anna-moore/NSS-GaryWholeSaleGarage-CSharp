using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new cars
            Zero Moto = new Zero()
            {
                BatteryKWh = 2000,
                MainColor = "white",
                MaximumOccupancy = "2",
                CurrentChargePercentage = 89
            };

            Cessna Ces = new Cessna()
            {
                FuelCapacity = 3600,
                MainColor = "gray",
                MaximumOccupancy = "10",
                CurrentTankPercentage = 40
            };

            Tesla Tes = new Tesla()
            {
                BatteryKWh = 2300,
                MainColor = "black",
                MaximumOccupancy = "4",
                CurrentChargePercentage = 23
            };

            Ram Ra = new Ram()
            {
                FuelCapacity = 340,
                MainColor = "sky blue",
                MaximumOccupancy = "5",
                CurrentTankPercentage = 60
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                Moto, Tes
            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}%");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}%");
            }
            Console.WriteLine("");
            /***********************************************/

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>(){
                Ra, Ces
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}%");
            }
            Console.WriteLine("");

            //Call method on all cars
            Ces.Drive();
            Ces.Turn("left");
            Ces.Stop();
            Console.WriteLine("");

            Tes.Drive();
            Tes.Turn("right");
            Tes.Stop();
            Console.WriteLine("");

            Ra.Drive();
            Ra.Turn("left");
            Ra.Stop();
            Console.WriteLine("");

            Moto.Drive();
            Moto.Turn("right");
            Moto.Stop();
            Console.WriteLine("");

        }
    }
}
