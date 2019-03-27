using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
   abstract public class Car : Automobile
   {
        public abstract decimal BasePrice { get; set; }
        public abstract decimal MilesPerGalon { get; set; }

        public override string Honk()
        {
            return "beep beep";
        }
        public override string SpeedUp()
        {
            return "brrrrr brrrrrr";
        }
    }
}
