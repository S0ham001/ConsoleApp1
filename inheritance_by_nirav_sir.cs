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

//want few members can be derived into child class but these members can't accessible 


namespace ConsoleApp1
{
    public class A
    {
        int x;
        public A(int x)
        {
            this.x = x;
            Console.WriteLine("base class A's constructor is called ");
        }
        public void method1()
        {
            Console.WriteLine("value of x is "+x);
        }
    }
    public class B : A
    {
        public B ():base(10)
        {
            Console.WriteLine("child calss B's constructor is called ");
        }
        public void method2()
        {
            Console.WriteLine("method 2 (B)");
        }
    }

    internal class inheritance_by_nirav_sir
    {
        static void Main()
        {
            B b = new B();
            b.method2();
            b.method1();
        }











































































































      

    }
}
