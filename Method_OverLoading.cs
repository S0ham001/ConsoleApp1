using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Method_OverLoading
    {
        public static void Main(string[] args)
        {
            int sum (int x,int y)
            {
                return x + y;
            }
            int sum (int x,int y,int z)
            {
                return x + y + z;
            }
            string sum(string x,string y)
            {
                return x + y;
            }

            int m1 = sum(1, 3);
            int m2 = sum(1, 3, 4);
            string m3 = sum("hello", "world");
            Console.WriteLine("sum with 2 ints",m1);
            Console.WriteLine("sum with 3 ints", m2);
            Console.WriteLine("sum with 2 strings", m3);


        }
    }
}

