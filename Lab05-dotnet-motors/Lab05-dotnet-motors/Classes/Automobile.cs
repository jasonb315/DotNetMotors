using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    /// <summary>
    ///     Project superclass
    /// </summary>
    abstract public class Automobile
    {
        public virtual int Seats {get; set;}
        public virtual int Wheels { get; set; }

        /// <summary>
        ///     Engine start
        /// </summary>
        /// <returns>string noise</returns>
        public virtual string Start()
        {
            return "whir-vroom";
        }

        /// <summary>
        ///     Brakes
        /// </summary>
        /// <returns>string noise</returns>
        public virtual string SlowDown()
        {
            return "scree";
        }

        /// <summary>
        ///     Accelerate
        /// </summary>
        /// <returns>atring noise</returns>
        public abstract string SpeedUp();
        /// <summary>
        ///     Honk
        /// </summary>
        /// <returns>string noise</returns>
        public abstract string Honk();

    }
}
