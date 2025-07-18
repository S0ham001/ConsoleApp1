using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Bhoomi_maam
    {
        public static void Main(string[] args)
        {
            //T1.1
            //Console.WriteLine("Hellow");


            //T1.2
            //Console.WriteLine("Name: Soham");
            //Console.WriteLine("DOB: 29/02/2004");
            //Console.WriteLine("Address: balaji_complex, vadal_main_road,tramba");
            //Console.WriteLine("City:Rajkot");
            //Console.WriteLine("Pin code: 360020");
            //Console.WriteLine("State: Gujrat");
            //Console.WriteLine("Contry: India");
            //Console.WriteLine("Email:sthummar444@rku.ac.in");


            //T1.3
            //Console.WriteLine("enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("Number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Number is odd");
            //}

            //T1.4 as Program.cs outside 


            //T1.5 as Peogram2.cs outside


            //T1.6 as Program3.cs outside


            ////T1.10(logic error)
            //Console.WriteLine("enter your phone number");
            //string no = Console.ReadLine();
            //string x = "";
            //for (int i = 0; i < no.Length / 2; i++)
            //{
            //    x = x + no[i];

            //}
            //x = x + "XXXXX";
            //Console.WriteLine(x);

            //T1.14
            //Console.Write("enter a number: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string ans = "";
            //while (num > 0)
            //{
            //    int digit = num % 10;
            //    num = num / 10;
            //    //Console.WriteLine(digit);
            //    if (digit == 0) { ans = "Zero " + ans; }
            //    else if (digit == 1) { ans = "one " + ans; }
            //    else if (digit == 2) { ans = "Two " + ans; }
            //    else if (digit == 3) { ans = "Three " + ans; }
            //    else if (digit == 4) { ans = "Four " + ans; }
            //    else if (digit == 5) { ans = "Five " + ans; }
            //    else if (digit == 6) { ans = "Six " + ans; }
            //    else if (digit == 7) { ans = "Seven " + ans; }
            //    else if (digit == 8) { ans = "Eight " + ans; }
            //    else { ans = "Nine " + ans; }
            //}
            //Console.WriteLine(ans);






            //T1.21
            //Console.Write("Enter a number ot terms: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //int j = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //int total = 0;
            //for (int i = 1; i <= num; i++)
            //{
            //    sum = sum + j;
            //    total = total + sum;
            //    j = j * 10;
            //    Console.Write(sum + " + ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(" total => " + total);


            //Tanna sir(majak)
            //Console.Write("enter a digit: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num + " " + num + " " + num);
            //for (int i = 1; i <= num; i++)
            //{
            //    Console.WriteLine(num + " " + i + " " + num);
            //}


            //pattern
            //*
            //#*
            //*#*
            //#*#*

            //Console.Write("enter a number of row: ");
            //int row = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i <= row; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (j % 2 == 0)
            //            {
            //                Console.Write("*");
            //            }
            //            if (j % 2 == 1)
            //            {
            //                Console.Write("#");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (j % 2 == 0)
            //            {
            //                Console.Write("#");
            //            }
            //            if (j % 2 == 1)
            //            {
            //                Console.Write("*");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}


            //array built in functions
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Array Length: " + a.Length);
            Console.WriteLine("Array Max: " + a.Max());
            Console.WriteLine("Array Min: " + a.Min());
            Console.WriteLine("Array Sum: " + a.Sum());
            Console.WriteLine("Array Average: " + a.Average());
            Console.WriteLine("Array Reverse: " + string.Join(", ", a.Reverse()));
            a.Append(11);
            foreach (var item in a)
            {
                Console.Write(item + ", ");
            }

            




































































        }

    }
}
