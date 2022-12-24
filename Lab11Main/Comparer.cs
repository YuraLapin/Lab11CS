using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class TransportComparer: IComparer<Transport>
    {
        public int Compare(Transport? t1, Transport? t2)
        {
            if (t1 == null || t2 == null)
            {
                return 0;
            }
            return t1.power.CompareTo(t2.power);
        }
    }

    public class StringComparer: IComparer<string>
    {
        public int Compare(string? s1, string? s2)
        {
            if (s1 == null || s2 == null)
            {
                return 0;
            }
            return s1.CompareTo(s2);
        }
    }
}
