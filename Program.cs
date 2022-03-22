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
            


        }
    }
}
