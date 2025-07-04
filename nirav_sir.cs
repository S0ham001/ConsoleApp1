using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class nirav_sir
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellow!");

        string str1,str2,str3;
            Console.WriteLine("enter string 1:");
            str1 = Console.ReadLine();
            Console.WriteLine("enter string 2:");
            str2 = Console.ReadLine();
            int len = str1.Length;
            Console.WriteLine("length of string is:" + len);
            str3 = str1.ToUpper();
            Console.WriteLine("string 1 in upper case:" + str3);
            str3 = str2.ToLower();
            Console.WriteLine("string 2 in lower case:" +str3);
            str3 = string.Concat(str1," ",str2);
            Console.WriteLine("combine string using concat:" + str3);
            str3 = str1 + " " + str2;
            Console.WriteLine("combine string:" + str3);
            int x = 10;
            str3 = $"Multiplication of number is :{x * 10}";
            Console.WriteLine("string 3 is :" + str3);











            Console.Read();
        }
    }
}
