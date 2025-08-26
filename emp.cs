using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class emp
    {
        public class Employee
        {
            private int empid;
            private string name;
            private string designation;
            private string instname;
            private double basic_Pay;
            public int Empid
            {
                get { return empid; }
                set { empid = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Designation
            {
                get { return designation; }
                set { designation = value; }
            }
            public string Instname
            {
                get { return instname; }
                set { instname = value; }
            }
            public double basicPay
            {
                get { return basic_Pay; }
                set { basic_Pay = value; }
            }
            public void display()
            {
                Console.WriteLine("Employee ID: " + empid);
                Console.WriteLine("Employee Name: " + name);
                Console.WriteLine("Employee Designation: " + designation);
                Console.WriteLine("Employee Instname: " + instname);
                Console.WriteLine("Employee basic pay: " + basic_Pay);
            }
            public static double calculateSalary(double basicPay)
            {
                return basicPay + (basicPay * 0.1) + (basicPay * 0.45);
            }
        }
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Empid = 101;
            emp1.Name = "Ron";
            emp1.basicPay = 25000;
            emp1.Designation = "Developer";
            emp1.Instname = "RK University";
            double emp1salry = Employee.calculateSalary(emp1.basicPay);

            Employee emp2 = new Employee();
            emp2.Empid = 102;
            emp2.Name = "Harry";
            emp2.basicPay = 30000;
            emp2.Designation = "Manager";
            emp2.Instname = "RK University";
            double emp2salry = Employee.calculateSalary(emp2.basicPay);

            if (emp2salry > emp1salry)
            {
                emp2.display();
                Console.WriteLine("Employee Salary: " + emp2salry);
            }
            else
            {
                emp1.display();
                Console.WriteLine("Employee Salary: " + emp1salry);
            }

        }
    }

}