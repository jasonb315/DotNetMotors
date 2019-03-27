using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    abstract public class Truck : Automobile, IReverse
    {
        public abstract decimal BasePrice { get; set; }
        public abstract decimal MilesPerGalon { get; set; }
        
        public override string Honk()
        {
            return "hoooooooooonk";
        }
        public override string SpeedUp()
        {
            return "ptt ptt brrrrrrrr";
        }
        public string Reverse()
        {
            Console.WriteLine("beeep beeep beeep");
            return "beeep beeep beeep";
        }
    }
}
