using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumFrom_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the find Maximum Program");

            Console.WriteLine("enter First number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Second number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter Third number");
            int num3 = int.Parse(Console.ReadLine());

            int max=MaximumNumberCheck.MaximumInteger(num1, num2, num3);
            Console.WriteLine("The Maximum value is= "+max);
        }
    }
}
