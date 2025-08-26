using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Demo2
{
    int x;
    static int y = 20;

    public Demo2(int x)
        {
            this.x = x;
        }

    public static int addNum()
    {
        Demo2 ob = new Demo2(30);
        return (ob.x + y);
    }

    public void show()
    {
        Console.WriteLine("X is :" + x);
        Console.WriteLine("Y is :" + y);
    }

}
    public static class StaticClass
    {
        // only allow static members,method and constructors

        static int x;

        static StaticClass()
        {
            x = 100;
        }
        public static void display()
        {
            Console.WriteLine("x is :" + x);
        }
    }

    internal class statickeyword
{
    public static void Main(string[] args)
    {
        Demo2 ob = new Demo2(30);
        
        ob.show();
            //to call static method use <<classname>>.<<methodname>>
            Console.WriteLine(Demo2.addNum());
            //we dont't need to create object of a static class
            StaticClass.display();
        }
}
}