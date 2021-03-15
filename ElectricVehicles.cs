using System;
using System.Collections.Generic;

namespace GarysWholesaleGarage
{
    public interface IElectricVehicle
    {
        double BatteryKWh { get; set; }

        int CurrentChargePercentage { get; set; }

        void ChargeBattery();

    }
}