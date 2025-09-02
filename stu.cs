using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class stu
    {
        public class Student_data
        {

            int roll_no;
            string name;
            string branch;
            int sem;
            int s1, s2, s3 = 0;
            double avg;

            public int Roll_no
            {
                set { roll_no = value; }
            }
            public int Sem
            {
                set { sem = value; }
            }
            public int S1
            {
                set { s1 = value; }
            }
            public int S2
            {
                set { s2 = value; }
            }
            public int S3
            {
                set { s3 = value; }
            }
            //public double Avg
            //{
            //    get { get_avg(); }
            //}
            public double Avg
            {
                get { return avg; }
                set { avg = value; }
            }
            public void get_avg()
            {
                avg = (s1 + s2 + s3) / 3;
                Avg = avg;
                Console.WriteLine("Average" + avg);
            }

            public Student_data (int rollno, string name, string branch,int sem, int s1,int s2, int s3)
            {
                this.roll_no = rollno;
                this.name = name;
                this.branch = branch;
                this.sem = sem;
                this.s1 = s1;
                this.s2 = s2;
                this.s3 = s3;
            }
            public void showDetails()
            {
                Console.WriteLine("rollno: " + roll_no);
                Console.WriteLine("name: " + name);
                Console.WriteLine("branch: " + branch);
                Console.WriteLine("semaster: " + sem);
                Console.WriteLine("subject-1 marks: " + s1);
                Console.WriteLine("subject-2s marks: " + s2);
                Console.WriteLine("subject-3 marks: " + s3);
            }

        }
        public static void Main(string[] args)
        {
            Student_data s1 = new Student_data(111,"AAA","CE",5,56,67,87);
            //s1.showDetails();
            //s1.get_avg();
            Student_data s2 = new Student_data(222, "BBB", "CE", 5,65, 76, 78);
            //s2.showDetails();
            //s2.get_avg();

            if (s1.Avg > s2.Avg)
            {
                s1.showDetails();
                s1.get_avg();

            }
            else
            {
                s2.showDetails();
                s2.get_avg();
            }



        }
    }
}
