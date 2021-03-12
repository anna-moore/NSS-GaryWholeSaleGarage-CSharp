using System;

namespace GarysWholesaleGarage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla zips by you.  Mmmmmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals aroung a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}