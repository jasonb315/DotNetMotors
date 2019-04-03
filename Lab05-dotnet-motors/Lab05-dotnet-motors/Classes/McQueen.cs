using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     McQueen extends RaceCar
    /// </summary>
    public class McQueen : RaceCar
    {
        public override decimal BasePrice { get; set; }
        public override decimal MilesPerGalon { get; set; }
        public override int Seats { get; set; }
        public override int Wheels { get; set; }
        public string CatchPhrase()
        {
            return "I'm a car";
        }
    }
}
