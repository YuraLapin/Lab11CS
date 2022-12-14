using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class TestCollections
    {
        public LinkedList<Transport> Collection1 = new LinkedList<Transport>();
        public LinkedList<string> Collection2 = new LinkedList<string>();
        public SortedDictionary<Transport, Train> Collection3 = new SortedDictionary<Transport, Train>(new TransportComparer());
        public SortedDictionary<string, Train> Collection4 = new SortedDictionary<string, Train>(new StringComparer());

        public TestCollections(int size)
        {
            for (int i = 0; i < size; ++i)
            {
                var train = new Train(i.ToString(), i, i);
                string str = train.BaseTransport.ToString();
                Collection1.AddLast(train.BaseTransport);
                Collection2.AddLast(str);
                Collection3.Add(train.BaseTransport, train);
                Collection4.Add(str, train);
            }            
        }
    }
}