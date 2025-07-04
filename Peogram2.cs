using System;
namespace ConsoleApplication1
{
    class Program2
    {
        static void Main(string[] args)
        {
            //variable decleration
            int n, fact = 1;
            //asking for input
            Console.WriteLine("Enter Number : ");
            //taking input from user
            string str = Console.ReadLine();
            //converting string to integer
            n = Convert.ToInt32(str);
            //calculating factorial using for loop
            for (int i = 1; i <= n; i++)
            {
                //multiplying each number to get factorial
                fact = fact * i;
            }
            //printing the factorial the output
            Console.WriteLine("Factorial : {0}", fact);

            Console.Read();
        }
    }
}
