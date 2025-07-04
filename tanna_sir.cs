using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tanna_sir
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            Console.WriteLine("2.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            Console.WriteLine("3.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 4; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
            Console.WriteLine("4.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");

            }
            Console.WriteLine("5.");
            int n = 5;
            for (int i = 1; i < 2; i++)
            {
                for(int j = 0;j <= n; j++)
                {
                    int a;
                    if(i == 0)
                    {
                        a = j;
                    }
                    else
                    {
                        a = n - j;
                    }
                    for (int k = 1; k <= a; k++)
                    {
                        Console.Write("*");
                    }
                     
                }
                Console.Write("\n");

            }

        }
    }
}
