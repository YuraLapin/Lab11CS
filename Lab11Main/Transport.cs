using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Transport: IComparable<Transport>, IEquatable<Transport>
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

        public virtual int CompareTo(Transport? t)
        {
            int res = 0;
            if (t != null)
            {
                res = string.Compare(this.name, t.name);
            }
            return res;    
        }

        public bool Equals(Transport? t)
        {
            if (t != null)
            {
                return string.Equals(this.name, t.name);
            }
            return false;
        }
    }
}