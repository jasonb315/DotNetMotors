﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    public class SubaruBahah : PickupTruck
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }
        public override int Seats { get; set; }
        public override int Wheels { get; set; }
        public string DerpDerp()
        {
            return "derp derp";
        }
    }
}
