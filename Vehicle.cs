using System;

namespace GarysWholesaleGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehile carefully turns {direction}.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The vehicle gently rolls to a stop!");
        }

    }
}