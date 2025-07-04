using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosoleApp1
{
    internal class read
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("enter a string value");
            str = Console.ReadLine();
            Console.WriteLine("String is " + str);
            int no1;
            int no2;
            Console.WriteLine("write two number no1 and no2");
            no1 = Convert.ToInt32(Console.ReadLine());
            no2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First number:" + no1);
            Console.WriteLine("Second number:" + no2);


            Console.Read();
        }
    }
}
