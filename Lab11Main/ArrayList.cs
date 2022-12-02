using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    internal class ArrayList: IList<IComparable>, ICollection<IComparable>, IEnumerable<IComparable>, ICloneable
    {
        IComparable[] arr;

        ArrayList()
        {
            arr = new IComparable[0];
        }

        ArrayList(in int size)
        {
            arr = new IComparable[size];
        }

        ArrayList(in IComparable[] arr)
        {
            this.arr = arr;
        }

        public int IndexOf(IComparable elem)
        {
            return Array.IndexOf(arr, elem);
        }

        public void Insert(int index, IComparable elem)
        {
            IComparable[] newArr = new IComparable[arr.GetLength(0) + 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            newArr[index] = elem;
            for (int i = index + 1; i < arr.GetLength(0) + 1; ++i)
            {
                newArr[i] = arr[i - 1];
            }
            arr = newArr;
        }

        public void RemoveAt(int index)
        {
            IComparable[] newArr = new IComparable[arr.GetLength(0) - 1];
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }
            for (int i = index + 1; i < arr.GetLength(0) + 1; ++i)
            {
                newArr[i] = arr[i + 1];
            }
            arr = newArr;
        }
    }
}
