using System;

namespace UC2_FindMaxNumberBy_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number of Float Value");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Second number of Float Value");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter third number of folat Value");
            float num3 = float.Parse(Console.ReadLine());


            float reault=MaxFloat.Maximum_Float(num1,num2,num3);
            Console.WriteLine("so maximum number is= "+reault);
        }
    }
}
