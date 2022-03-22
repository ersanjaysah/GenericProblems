using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC4_UsingOption_andSorting
{
    public class GenericMaximum<T> where T:IComparable
    {
        public T[] Value;       

        public GenericMaximum(T[] value)   //constructor
        {
            this.Value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
           
        }

        public T MaxValueFromArray(T[] values)
        {
            T[] sorted_values = Sort(values);
            return sorted_values[sorted_values.Length - 1];
        }

        public T MaxMethodFromArray()
        {
            var max = MaxValueFromArray(this.Value);
            return max;
        }

        public void PrintMaxValue()
        {
            var max=MaxValueFromArray(this.Value);
            Console.WriteLine("Maximum Value is = "+max);
        }


    }
}
