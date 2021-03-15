using System;

namespace GarysWholesaleGarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery()
        {
            Console.WriteLine("Charging the battery.");
            CurrentChargePercentage = 100;
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero zips by you. Yeeeeoooowww!");
        }
    }
}