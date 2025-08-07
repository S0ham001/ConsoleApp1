using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class tanna_sir
    {
        class A
        {
            private string fname;

            public string getFname() { return fname; }
            public void setFname(string name) { this.fname = name; }

            public string FirstName
            {
                get {
                    
                    return fname; }
                set { fname = value; }
            }
        }
        class Students
        {
            private string enrollno;
            private string name;
            public string getname() { return name; }
            public void setFname(string name) { this.name = name; }

            public string getenrolno() { return enrollno; }
            public void setenrollno(string num) { this.enrollno = num; }

            public string GetName
            {
                get { return name; }
                set { name = value; }
            }
            public string GetEnrollno
            {
                get { return enrollno; }
                set { enrollno = value; }
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

            //A a = new A();
            //a.setFname("Tanna Sir (method)");
            //string m = a.getFname();
            //Console.WriteLine(m);

            //a.FirstName = "Tanna Sir (property)";
            //string p = a.FirstName;
            //Console.WriteLine(p);

            Students s = new Students();
            s.setenrollno("1");
            s.setFname("ron");
            Console.WriteLine(s.getenrolno());
            Console.WriteLine(s.getname());

            s.GetName = "mon";
            s.GetEnrollno = "2";
            Console.WriteLine(s.GetEnrollno);
            Console.WriteLine(s.GetName);

        }
    }
}

