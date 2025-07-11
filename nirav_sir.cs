using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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

            int[] arr5 = new int[5];
            Console.WriteLine("enter array elements:");
            for (int i = 0; i < arr5.Length; i++)
            {
                arr5[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr5.Length; i++)
            {
                for (int j = i + 1; j < arr5.Length; j++)
                {
                    if (arr5[i] > arr5[j])
                    {
                        int temp = arr5[i];
                        arr5[i] = arr5[j];
                        arr5[j] = temp;
                    }
                }
            }
            Console.WriteLine("printing sorted array");
            foreach (int var in arr5)
            {
                Console.WriteLine(var);
            }

            //bool[] freq = new bool[6];
            //int[] arr6 = new int[6];
            //Console.WriteLine("enter array elements:");
            //for (int i = 0; i < arr6.Length; i++)
            //{
            //    arr6[i] = Int32.Parse(Console.ReadLine());
            //}

            //for (int i = 0;i < arr6.Length; i++)
            //{
            //    if (freq[i] == true)
            //         continue;

            //        int cnt = 1;
            //        for(int j = i+1; j<arr6.Length; j++)
            //        {
            //            if (arr6[j] == arr6[i])
            //            {
            //                freq[j] = true;
            //                cnt++;
            //            }
            //        }
            //        Console.WriteLine("frequency of {0} is {1} times", arr6[i], cnt);

            //}



            Console.Read();
        }
    }
}
