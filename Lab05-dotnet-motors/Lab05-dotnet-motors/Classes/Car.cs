using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     Car extends Automobile
    /// </summary>
   abstract public class Car : Automobile
   {
        public abstract decimal BasePrice { get; set; }
        public abstract decimal MilesPerGalon { get; set; }

        /// <summary>
        ///     Car makes noise
        /// </summary>
        /// <returns>string noise</returns>
        public override string Honk()
        {
            return "beep beep";
        }
        /// <summary>
        ///     Cars go fast
        /// </summary>
        /// <returns>string sound</returns>
        public override string SpeedUp()
        {
            return "brrrrr brrrrrr";
        }
    }
}
