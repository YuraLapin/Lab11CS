using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab11Main
{
    public class ArrayList: IList<IComparable>, ICollection<IComparable>, IEnumerable<IComparable>, ICloneable
    {
        public IComparable[] arr;             

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
            this.arr = new IComparable[arr.Length];
            for (int i = 0; i < arr.Length; ++i)
            {
                this.arr[i] = arr[i];
            }
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

        public bool Remove(IComparable elem)
        {            
            if (IndexOf(elem) >= 0)
            {
                RemoveAt(IndexOf(elem));
                return true;
            }
            return false;
        }

        public IComparable this[int index]
        {
            get
            {
                try
                {
                    return arr[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
            set
            {                
                try
                {
                    arr[index] = value;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }                              
            }
        }

        IEnumerator<IComparable> IEnumerable<IComparable>.GetEnumerator()
        {
            return (IEnumerator<IComparable>)GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ArrayListEnum GetEnumerator()
        {
            return new ArrayListEnum(arr);
        }

        public void Add(IComparable elem)
        {
            var newArr = new IComparable[arr.Length + 1];
            for (int i = 0; i < arr.Length; ++i)
            {
                newArr[i] = arr[i];
            }
            newArr[arr.Length] = elem;
            arr = newArr;
        }

        public void Clear()
        {
            Array.Clear(arr);
        }

        public bool Contains(IComparable elem)
        {
            if (IndexOf(elem) < 0)
            {
                return false;
            }
            return true;
        }        

        public void CopyTo(IComparable[] arr, int index)
        {
            if (index >= 0)
            {
                var newArr = new IComparable[arr.Length + Count - index];
                for (int i = 0; i < arr.Length; ++i)
                {
                    newArr[i] = arr[i];
                }
                for (int i = index; i < this.arr.Length; ++i)
                {
                    newArr[i] = this.arr[i - arr.Length + index];
                }           
            }
        }

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public object Clone()
        {
            return new ArrayList(arr);
        }

        public override bool Equals(object obj)
        {
            if (obj is ArrayList)
            {
                return Array.Equals(arr, ((ArrayList)obj).arr);
            }
            if (obj is IComparable[])
            {
                return Array.Equals(arr, obj);
            }
            return false;
        }
    }

    public class ArrayListEnum: IEnumerator
    {
        public IComparable[] arr;
        int position = -1;

        public ArrayListEnum(IComparable[] arr)
        {
            this.arr = arr;
        }

        public bool MoveNext()
        {
            position++;
            return (position < arr.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public IComparable Current
        {
            get
            {
                try
                {
                    return arr[position];
                }
                catch(IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

        public void Dispose()
        {
            Array.Clear(arr);
        }
    }
}