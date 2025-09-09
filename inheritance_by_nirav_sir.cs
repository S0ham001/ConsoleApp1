using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




//inheritance in C#
/*
- it is a process of creating a new class from already exist class
- already exist class is known as perent/base/super class
- newly created class is known as child/derived/sub class
- used for code reusability
- perent class properties can be consumed by child class
- access specifier used to restrict the properties to inherit
- private members never be inherited
*/
//types of inheritance
/*
1. single level
2. multi level
3. hierarchical
4. multiple
5. hybrid
 */

//want few members can be derived into child class but these members can't accessible 


namespace ConsoleApp1
{
    public class A
    {
        protected int x;
        public A(int x)
        {
            this.x = x;
            Console.WriteLine("base class A's constructor is called ");
        }
        public void method1()
        {
            Console.WriteLine("value of x from class A is "+x);
        }
        public int X
        {
            get { return x; }
        }
    }
    public class B : A
    {
        protected int y;
        public B (int x,int y):base(10)
        {
            this.y = y;
            Console.WriteLine("child calss B's constructor is called ");
        }
        public void method2()
        {
            Console.WriteLine("value of x from class B is "+y);
        }
        public int Y
        {
            get { return y; }
        }
        //public double get_avg()
        //{
        //    int avg = (x + y) / 2;
        //    Console.WriteLine("avg of X and Y is " + avg);
        //    return avg;
        //}
    }

    internal class inheritance_by_nirav_sir
    {
        static void Main()
        {
            B b = new B(18,20);
            b.method2();
            b.method1();
            //Console.WriteLine(b.get_avg());
            double avg = (b.X + b.Y) / 2;
            Console.WriteLine(avg);
        }


        //vehicle.cs








































































































      

    }
}
