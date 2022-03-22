using System;

namespace UC4_UsingOption_andSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum number");

            int[] intArray = { 3, 4, 7, 9, 2 };
            GenericMaximum<int> obj = new GenericMaximum<int>(intArray);
            obj.PrintMaxValue();

            double[] doubleArray = { 1.1, 34.4, 43.5, 86.4, 76.54 };
            GenericMaximum<double> obj1 = new GenericMaximum<double>(doubleArray);
            obj1.PrintMaxValue();

            string[] stringArray = { "ram", "shyam", "45", "56", "mohan" };
            GenericMaximum<string> obj2 = new GenericMaximum<string>(stringArray);
            obj2.PrintMaxValue();
        }
    }
}
