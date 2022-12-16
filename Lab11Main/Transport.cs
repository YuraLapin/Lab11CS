using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Transport: IComparable
    {
        public string name;
        public int power;

        public Transport()
        {
            name = "";
            power = 0;
        }

        public Transport(in string name, in int maxSpeed)
        {
            this.name = name;
            this.power = maxSpeed;
        }        
        
        public override string ToString()
        {
            return name.ToString() + ": power - " + power.ToString();
        }        

        public static explicit operator Person(Transport obj)
        {
            return new Person(obj.name, 0, 0);
        }        

        public int CompareTo(object obj)
        {
            int res = 0;
            if (obj is Transport c) 
            {
                res = string.Compare(this.name, c.name);
            }
            if (obj is Person p)
            {
                res = string.Compare(this.name, p.name);
            }
            return res;    
        }

        public override bool Equals(object obj)
        {
            if (obj is Transport t)
            {
                return name.Equals(t.name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}