using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class emp
    {
        public class Emp
        {
            int empid;
            string name;
            string designation;
            //string instname;
            double basic_Pay;
            double Da;
            double Hra;
            double totalPay;

            public Emp(int empid, string name, string designation , double basic_pay) 
            {
                this.empid = empid;
                this.name = name;
                this.designation = designation;
                this.basic_Pay = basic_pay;
            }

            public void getDa()
            {
                this.Da = .45*basic_Pay;
            }
            public void getHra()
            {
                this.Hra = .2 * basic_Pay;
            }
            public void calTotalPay()
            {
                getDa();
                getHra();
                this.totalPay = this.Da + this.Hra + this.basic_Pay;
            }
            public void getTotalPay()
            {
                Console.WriteLine(this.totalPay);
            }

        }
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
            //Employee emp1 = new Employee();
            //emp1.Empid = 101;
            //emp1.Name = "Ron";
            //emp1.basicPay = 25000;
            //emp1.Designation = "Developer";
            //emp1.Instname = "RK University";
            //double emp1salry = Employee.calculateSalary(emp1.basicPay);

            //Employee emp2 = new Employee();
            //emp2.Empid = 102;
            //emp2.Name = "Harry";
            //emp2.basicPay = 30000;
            //emp2.Designation = "Manager";
            //emp2.Instname = "RK University";
            //double emp2salry = Employee.calculateSalary(emp2.basicPay);

            //if (emp2salry > emp1salry)
            //{
            //    emp2.display();
            //    Console.WriteLine("Employee Salary: " + emp2salry);
            //}
            //else
            //{
            //    emp1.display();
            //    Console.WriteLine("Employee Salary: " + emp1salry);
            //}

            Emp e1 = new Emp(111, "AAA", "S-SE", 12000);
            e1.getTotalPay();
            Emp e2 = new Emp(112, "AAB", "J-SE", 11000);
            e2.getTotalPay();



        }
    }

}