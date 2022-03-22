using System;

namespace Refactor1_UC1_UC2_UC3_ByGenericMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GenericMaximum<int> obj2 = new GenericMaximum<int>();
            int result2=obj2.MaximumValue(16,87,98);
            Console.WriteLine("Maximum value of integer is = "+result2);

            GenericMaximum<double> obj1 = new GenericMaximum<double>();
            double result1=obj1.MaximumValue(23.45, 25.645, 87.54);
            Console.WriteLine("Maximum value of double is = "+result1);

            GenericMaximum<string> obj = new GenericMaximum<string>();
            string result=obj.MaximumValue("45","35","49");
            Console.WriteLine("maximum Value of string is = "+result);
        }
    }
}
