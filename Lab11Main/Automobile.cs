using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Automobile: Transport
    {
        public int wheels;

        public Transport BaseTransport
        {
            get
            {
                return new Transport(name, power);
            }
        }

        public Automobile(): base()
        {
            this.wheels = 0;
        }

        public Automobile(in string name, in int maxSpeed, in int horsepowers): base(name, maxSpeed)
        {
            this.wheels = horsepowers;
        }        

        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString() + ", wheels - " + wheels.ToString();
        }        
    }
}