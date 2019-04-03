using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     RaceCar extends Car
    /// </summary>
    abstract public class RaceCar : Car
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }



        public string Turbo()
        {
            return "FROOSH";
        }

    }
}
