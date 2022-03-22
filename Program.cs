using System;

namespace Uc4MaxMethod_WithParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[] doubleArray = new double[5];
            Console.WriteLine("enter array elements");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                doubleArray[i] = double.Parse(Console.ReadLine());
            }

            Array.Sort(doubleArray);       // sorting an array
            int a = doubleArray.Length - 1;
            Console.WriteLine("the maximum number is= " + doubleArray[a]);
            Console.WriteLine("sorted list of an Array is");
            foreach (double i in doubleArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}
