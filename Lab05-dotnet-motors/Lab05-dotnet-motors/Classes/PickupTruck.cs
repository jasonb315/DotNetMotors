using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    abstract public class PickupTruck : Truck
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }

        public string Haul()
        {
            return "Load er up drop er off";
        }
    }
}
