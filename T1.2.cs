﻿using System;
namespace ConsoleApp1
{
    internal class program22
    {
        public static void Main(string[] args)
        {
            int n = 5;



            for (int i = 1; i <= n; i++)
            {

                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");



                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");


                Console.WriteLine();
            }



            for (int i = n - 1; i >= 1; i--)
            {

                for (int j = 1; j <= n - i; j++)
                    Console.Write(" ");



                for (int k = 1; k <= 2 * i - 1; k++)
                    Console.Write("*");


                Console.WriteLine();
            }
        }
    }
}
