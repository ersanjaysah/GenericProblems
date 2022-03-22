using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1_UC1_UC2_UC3_ByGenericMethod
{
    public class GenericMaximum<T>where T:IComparable
    {
        public T MaximumValue(T firstValue, T secondValue, T thirdValue)
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
            return firstValue;

        }
    }
}
