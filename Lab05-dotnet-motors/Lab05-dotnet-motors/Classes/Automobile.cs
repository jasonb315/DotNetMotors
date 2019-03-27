using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_dotnet_motors.Classes
{
    abstract public class Automobile
    {
        public virtual int Seats {get; set;}
        public virtual int Wheels { get; set; }

        public virtual string Start()
        {
            return "whir-vroom";
        }
        public virtual string SlowDown()
        {
            return "scree";
        }

        public abstract string SpeedUp();
        public abstract string Honk();

    }
}
