using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class cal
    {
        static int Add (int a, int b)
        {
            return a + b;
        }
        static int Sub (int a,int b)
        {
            return a - b;
        }
        static int Multi(int a, int b)
        {
            return a * b;
        }
        static int division(int a, int b)
        {
            return a / b;
        }

        static void Swap(ref int x, ref int y)
        {
            x = x + y;
            y = x - y;
            x = x - y;

        }
        static void Update(out int x, out int y)
        {
            x = 100;
            y = 200;

        }

        public static void Main(String [] args)
        {
            int a = 1, b=2;
            int x = 10, y = 20;
            int result;
            result = Add(a,b);
            Console.WriteLine("addition: "+result);
            result = Sub(a, b);
            Console.WriteLine("Substration: " + result);
            result = Multi(a, b);
            Console.WriteLine("Multiplication: " + result);
            result = division(a, b);
            Console.WriteLine("Division: " + result);
            //Console.WriteLine("{0}", result);

            Console.WriteLine("Before Swap: x = " + a + ", y = " + b);
            Swap(ref a, ref b);
            Console.WriteLine("after Swap: x = " + a + ", y = " + b);

            Console.WriteLine("Before Swap: x = " + x + ", y = " + y);
            Update(out x, out y);
            Console.WriteLine("after Swap: x = " + x + ", y = " + y);

        }
    }
}
