using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Express: Train
    {
        public List<string> stationsToSkip;

        public Train BaseTrain
        {
            get
            {
                return new Train(name, power, cars);
            }
        }

        public Express(): base()
        {
            stationsToSkip = new List<string>();
        }

        public Express(in string name, in int maxSpeed, in int cars, in List<string> stationsToSkip): base(name, maxSpeed, cars)
        {
            this.stationsToSkip = stationsToSkip;
        }        

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(name.ToString() + ": power - " + power.ToString() + ", cars - " + cars.ToString() + ", list of stations to skip: [ ");
            if (stationsToSkip.Count > 0)
            {
                foreach (string s in stationsToSkip)
                {
                    sb.Append(s + ", ");
                }
                sb.Append("]");
            }
            else
            {
                sb.Append("- ]");
            }
            return sb.ToString();
        }        
    }
}