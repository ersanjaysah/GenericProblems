using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor2_UsingGenericClass
{
    public class GenericMaximum<T> where T:IComparable
    {
        public T FirstValue;
        public T SecondValue; 
        public T ThirdValue;

        public GenericMaximum(T firstValue, T secondValue , T thirdValue )
        {
            this.FirstValue = firstValue;
            this.SecondValue = secondValue;
            this.ThirdValue = thirdValue;

        }

        public static T MaximumValue(T firstValue, T secondValue, T thirdValue)
        {
            if(firstValue.CompareTo(secondValue)>0 && firstValue.CompareTo(thirdValue)>0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0 )
            {
                return firstValue;
            }
            if(secondValue.CompareTo(firstValue)>0 && secondValue.CompareTo(thirdValue)>0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0 )
            {
                return secondValue;
            }
            if(thirdValue.CompareTo(firstValue)>0 && thirdValue.CompareTo(secondValue)>0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0 )
            {
                return thirdValue;
            }
            return default;
        }
         public  T MaxMethod()
         {
            T max = GenericMaximum<T>.MaximumValue(this.FirstValue, this.SecondValue, this.ThirdValue);
            return max;
            
         }
    }
}
