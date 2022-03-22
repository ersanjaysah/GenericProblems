using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC3_FindMax_WithString
{
    public class MaxFromString
    {
        public static string Maximum_String(string firstNumber, string secondNumber, string thirdNumber)
        {
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) >= 0 && firstNumber.CompareTo(thirdNumber) > 0 ||
                firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) >= 0)
            {
                return firstNumber;
            }
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) >= 0 && secondNumber.CompareTo(thirdNumber) > 0 ||
                secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) >= 0)
            {
                return secondNumber;
            }
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) >= 0 && thirdNumber.CompareTo(secondNumber) > 0 ||
                thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) >= 0)
            {
                return thirdNumber;
            }
            return firstNumber;
        }
    }
}
