using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    abstract public class CommuterCar : Car
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }

        public string AudioBook()
        {
            return "this is audible";
        }
    }
}
