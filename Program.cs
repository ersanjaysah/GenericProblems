using System;

namespace UC3_FindMax_WithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum From string");

            Console.WriteLine("Enter First string Value");
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter Second string Value");
            string num2 = Console.ReadLine();

            Console.WriteLine("Enter Third string Value");
            string num3 = Console.ReadLine();


           string result=MaxFromString.Maximum_String(num1,num2,num3);
            Console.WriteLine("The Maximum Value is = "+result);
        }
    }
}
