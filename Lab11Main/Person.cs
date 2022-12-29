using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Main
{
    public class Person: IComparable, ICloneable
    {
        public string name;
        public int age;
        public int height;

        public Person()
        {
            name = "";
            age = 0;
            height = 0;
        }

        public Person(in string name)
        {
            this.name = name;
            age = 0;
            height = 0;
        }

        public Person(in string name, in int age, in int height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }        

        public override string ToString()
        {
            return name + ": age - " + age + ", height - " + height;
        }

        public static explicit operator Transport(Person obj)
        {
            return new Transport(obj.name, 0);
        }        

        public int CompareTo(object? obj)
        {
            int res = 0;
            if (obj != null)
            {
                if (obj is Transport c)
                {
                    res = string.Compare(this.name, c.name);
                }
            }                
            return res;
        }

        public object Clone()
        {
            return new Person(name, age, height);
        }

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }
    }
}