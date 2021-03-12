using System;

namespace GarysWholesaleGarage
{
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna zips by you like a hurricane.  Zoooooom!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rools down the runway for a mile and stops.");
        }
    }
}