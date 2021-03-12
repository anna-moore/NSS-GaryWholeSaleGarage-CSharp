using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero moto = new Zero()
            {
                BatteryKWh = 2000,
                MainColor = "white",
                MaximumOccupancy = "2"
            };

            Cessna Ces = new Cessna()
            {
                FuelCapacity = 3600,
                MainColor = "gray",
                MaximumOccupancy = "10"
            };

            Tesla tes = new Tesla()
            {
                BatteryKWh = 2300,
                MainColor = "black",
                MaximumOccupancy = "4"
            };

            Ram ra = new Ram()
            {
                FuelCapacity = 340,
                MainColor = "sky blue",
                MaximumOccupancy = "5"
            };
        }
    }
}
