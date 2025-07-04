using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bhoomi_maam
    {
        public static void Main(string[] args)
        {
            Console.Write("enter 1st number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter 2nd number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"sum is {a} + {b} = " + sum);
            Console.Read();
        }

    }
}
