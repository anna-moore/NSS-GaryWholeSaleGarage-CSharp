using System;

namespace GarysWholesaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero Moto = new Zero()
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

            Tesla Tes = new Tesla()
            {
                BatteryKWh = 2300,
                MainColor = "black",
                MaximumOccupancy = "4"
            };

            Ram Ra = new Ram()
            {
                FuelCapacity = 340,
                MainColor = "sky blue",
                MaximumOccupancy = "5"
            };

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
