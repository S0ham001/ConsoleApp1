﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Emoloyee
    {
        int empId;
        string ename;
        int salary;
        public void getData(int empId, string ename, int salary)
        {
            this.empId = empId;
            this.ename = ename;
            this.salary = salary;
        }
        public void showDate()
        {
            Console.WriteLine("empId = " + empId);
            Console.WriteLine("name = " + ename);
            Console.WriteLine("salaey = " + salary);
            Console.WriteLine();

        }
        public int getsalary()
        {
            return salary;

        }
    }
    public class Time
    {
        int hour;
        int min;
        int sec;
        public void getTime(int hour, int min, int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
        public void showTime()
        {
            Console.WriteLine("time is: " + hour + ":" + min + ":" + sec);
        }
        public void nextsec()
        {
            sec++;
            if (sec == 60)
            {
                sec = 0;
                min++;
                if (min == 60)
                {
                    min = 0;
                    hour++;
                    if (hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
    }


    internal class nirav_sir
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hellow!");

            //string str1,str2,str3;
            //    Console.WriteLine("enter string 1:");
            //    str1 = Console.ReadLine();
            //    Console.WriteLine("enter string 2:");
            //    str2 = Console.ReadLine();
            //    int len = str1.Length;
            //    Console.WriteLine("length of string is:" + len);
            //    str3 = str1.ToUpper();
            //    Console.WriteLine("string 1 in upper case:" + str3);
            //    str3 = str2.ToLower();
            //    Console.WriteLine("string 2 in lower case:" +str3);
            //    str3 = string.Concat(str1," ",str2);
            //    Console.WriteLine("combine string using concat:" + str3);
            //    str3 = str1 + " " + str2;
            //    Console.WriteLine("combine string:" + str3);
            //    int x = 10;
            //    str3 = $"Multiplication of number is :{x * 10}";
            //    Console.WriteLine("string 3 is :" + str3);



            //int[] arr1 = new int[5];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;
            //arr1[3] = 40;
            //arr1[4] = 50;

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr1[1]);
            //Console.WriteLine(arr1[2]);
            //Console.WriteLine(arr1[3]);
            //Console.WriteLine(arr1[4]);

            //int[] arr2 = { 1, 2, 3, 4, 5 };

            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //foreach(int var in arr1)
            //{
            //    Console.WriteLine(var);
            //}
            //int sum = 0;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    arr1[i] = Int32.Parse(Console.ReadLine());
            //    sum = sum + arr1[i];

            //}
            //Console.WriteLine("printing avg");
            ////foreach (int i in arr1)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //int avg = sum / arr1.Length;
            //Console.WriteLine(avg);

            //int[] arr3 = new int[5];
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    arr3[i] = Int32.Parse(Console.ReadLine());
            //}
            //int element;
            //Console.WriteLine("entre a element to search in array");
            //element = Convert.ToInt32(Console.ReadLine());

            //int flag = 0;
            //for (int i = 0; i < arr3.Length; i++) { 
            //    if (arr3[i] == element)
            //    {
            //        flag = 1;
            //        Console.WriteLine(arr3[i]);
            //    }
            //}
            //Console.WriteLine(flag);
            //int x = 0;
            //int[] arr4 = new int[5];
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < arr4.Length; i++)
            //{
            //    arr4[i] = Int32.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr4.Length;i++)
            //{
            //    if (x < arr4[i])
            //    {
            //        x = arr4[i];

            //    }
            //}
            //Console.WriteLine(x);

            //int[] arr5 = new int[5];
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    arr5[i] = Int32.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr5.Length; i++)
            //{
            //    for (int j = i + 1; j < arr5.Length; j++)
            //    {
            //        if (arr5[i] > arr5[j])
            //        {
            //            int temp = arr5[i];
            //            arr5[i] = arr5[j];
            //            arr5[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("printing sorted array");
            //foreach (int var in arr5)
            //{
            //    Console.WriteLine(var);
            //}

            //bool[] freq = new bool[6];
            //int[] arr6 = new int[6];
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    arr6[i] = Int32.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    if (freq[i] == true)
            //        continue;

            //    int cnt = 1;
            //    for (int j = i + 1; j < arr6.Length; j++)
            //    {
            //        if (arr6[j] == arr6[i])
            //        {
            //            freq[j] = true;
            //            cnt++;
            //        }
            //    }
            //    Console.WriteLine("frequency of {0} is {1} times", arr6[i], cnt);

            //}


            //int[,] arr7 = new int[2, 2];
            //arr7[0, 0] = 1;
            //arr7[0, 1] = 2;
            //arr7[1, 0] = 3;
            //arr7[1, 1] = 4;
            //Console.WriteLine(arr7[0, 0]);
            //Console.WriteLine(arr7[0, 1]);
            //Console.WriteLine(arr7[1, 0]);
            //Console.WriteLine(arr7[1, 1]);

            //int[,] arr8 = { { 1, 2 }, { 3, 4 } };
            //Console.WriteLine(arr8[0, 0]);
            //Console.WriteLine(arr8[0, 1]);
            //Console.WriteLine(arr8[1, 0]);
            //Console.WriteLine(arr8[1, 1]);

            //int[,] arr9 = { { 1, 2 }, { 4, 5}, { 7, 8} };
            //Console.WriteLine(arr9[0, 0]);
            //Console.WriteLine(arr9[0, 1]);
            //Console.WriteLine(arr9[1, 0]);

            //Console.WriteLine(arr9[1, 1]);
            //Console.WriteLine(arr9[2, 0]);
            //Console.WriteLine(arr9[2, 1]);
            //
            //int[,] arr10 = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            //for (int i = 0; i < arr10.GetLength(1); i++)
            //{
            //    for (int j = 0; j< arr10.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr10[i, j]);
            //    }               
            //}

            //int[,] arr11 = new int[3, 3];
            //for(int i = 0;i < arr11.GetLength(0); i++)
            //{
            //    for(int j = 0;j< arr11.GetLength(1); j++)
            //    {
            //        arr11[i,j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < arr11.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr11.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr11[i, j]+" ");
            //    }
            //    Console.WriteLine();
            //}   

            //int[,] arr1 = { { 1, 2 }, { 2, 3 } };
            //int[,] arr2 = { { 2, 3 }, { 2, 4 } };
            //int[,] sum = new int[2,2];
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        sum[i, j] = arr1[i, j] + arr2[i, j];
            //        Console.Write(sum[i, j]+" ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //int[][] jarr = new int[7][];
            //jarr[0] = new int[1];
            //jarr[1] = new int[2];
            //jarr[2] = new int[3];
            //jarr[3] = new int[4];
            //jarr[4] = new int[3];
            //jarr[5] = new int[2];
            //jarr[6] = new int[1];


            //Console.WriteLine("enter jagged array elements");
            //for (int i = 0; i < jarr.Length; i++)
            //{
            //    for (int j = 0; j < jarr[i].Length; j++)
            //    {
            //        jarr[i][j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("enter a number to search it in it");
            //int search = Convert.ToInt32(Console.Read());
            //Console.WriteLine("jagged array is:");
            //for (int i = 0; i < jarr.Length; i++)
            //{
            //    for (int j = 0; j < jarr[i].Length; j++)
            //    {
            //        Console.Write(jarr[i][j] + " ");
            //        //if (search == jarr[i][j])
            //        //{
            //        //    Console.WriteLine("found at index: " + i + "," + j);
            //        //}
            //    }
            //    Console.WriteLine(" ");
            //}

            //Console.WriteLine("commandline args:");
            //Console.WriteLine("first line: " + args[0]);
            //Console.WriteLine("second line: " + args[1]);

            //foreach (var arg in args)
            //{
            //    Console.WriteLine($"{arg}");
            //}

            //Emoloyee emp1 = new Emoloyee();
            //emp1.getData(1,"jhonny",10000);
            ////emp.showDate();
            //Emoloyee emp2 = new Emoloyee();
            //emp2.getData(2, "silver", 7500);
            ////emp.showDate();

            //if (emp1.getsalary() > emp2.getsalary())
            //{
            //    emp1.showDate();
            //}
            //else
            //{
            //    emp2.showDate();
            //}

            Time t1 = new Time();
            t1.getTime(11, 30, 45);
            t1.nextsec();
            t1.showTime();

            Time t2 = new Time();
            t2.getTime(12, 44, 59);
            t2.nextsec();
            t2.showTime();
            Console.Read();
        }
    }
}
