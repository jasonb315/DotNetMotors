using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     SemiTruck extends Truck
    /// </summary>
    abstract public class SemiTruck : Truck
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }

        public string Tow()
        {
            return "Git er done!";
        }
    }
}
