﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     ClownCar extends CommuterCar. Interface: IServeIceCream, IReverse
    /// </summary>
    public class ClownCar : CommuterCar, IServeIceCream, IReverse
    {
        
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }
        public override int Seats { get; set; }
        public override int Wheels { get; set; }

        public string Reverse()
        {
            return("wonka wonka");
        }

        public string ServeIceCream()
        {
            Console.WriteLine("Here ya go kids!");
            return "Here ya go kids!";
        }

        public string Unpack()
        {
            return "100 clowns get out";
        }

    }
}
