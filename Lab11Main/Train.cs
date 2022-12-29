using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Train : Transport, IComparable<Train>, IEquatable<Train>
    {
        public int cars;
        public Transport BaseTransport
        {
            get
            {
                return new Transport(name, power);
            }
        }

        public Train() : base()
        {
            cars = 0;
        }

        public Train(in string name, in int maxSpeed, in int cars) : base(name, maxSpeed)
        {
            this.cars = cars;
        }        

        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString() + ", cars - " + cars.ToString();
        }  
        
        public int CompareTo(Train? t)
        {
            int res = 0;
            if (t != null)
            {
                res = string.Compare(this.name, t.name);
            }
            return res;
        }

        public bool Equals(Train? t)
        {
            if (t != null)
            {
                return string.Equals(this.name, t.name);
            }
            return false;
        }
    }
}