using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tanna_sir
    {
        public class Employee
        {
            int empId;
            string name;
            string city;

            public Emoloyee() { }
            public Emoloyee(int empId, string name)
            {
                this.empId = empId;
                this.name = name;
            }
            public Emoloyee(int empId, string name, string city) : this.(empId, name)
            {
                this.city = city;
            }    
}
            
        public static void Main(string[] args)
        {
            //Console.WriteLine("1.");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");

            //}
            //Console.WriteLine("2.");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");

            //}
            //Console.WriteLine("3.");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 4; j >= i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.Write("\n");

            //}
            //Console.WriteLine("4.");
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.Write("\n");

            //}
            //Console.WriteLine("5.");

            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}
            //for (int i = 4 - 1; i >= 1; i--)
            //{
            //    Console.WriteLine(new string('*', i));
            //}
            //Console.WriteLine("5,");

            //for (int t = 1; t <= 10; t++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("table of: "+t);
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        int ans = t * i;
            //        Console.WriteLine(t + " x " + i+" = " +ans);
            //    }
            //}

            //practice
            //
            //int a = 5;
            //int b = 5;
            //int res = ++a + b++ + b++ + a++ + ++a + ++b + a++;
            //Console.WriteLine(res);
            //
            //

            //int addition(int a , int b)
            //{
            //    int ans;
            //    ans = a + b;
            //    return ans;
            //}

            //int add = addition(10, 20);
            //Console.WriteLine(add);

            //int substraction(int a, int b)
            //{
            //    int ans;
            //    ans = a - b;
            //    return ans;
            //}

            //int sub = substraction(10, 20);
            //Console.WriteLine(sub);


            

        }
    }
}

