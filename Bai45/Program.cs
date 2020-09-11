using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
/*
*  Hàm tính tổng các phần tử trong dãy số nguyên.
*/
namespace Bai45
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = nhap();
            xuat(arr);
            Console.WriteLine(sum(arr));
        }

        private static int sum(int[] arr)
        {
            int sum = 0;
            foreach(int temp in arr)
            {
                sum += temp;
            }
            return sum;
        }

        private static int[] nhap()
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine().Trim(), "\\s+");
            return converStringToInt(input_arr);
        }

        private static void xuat(int[] arr)
        {
            Console.WriteLine("Cac phan tu trong mang la : ");
            foreach (int temp in arr) Console.Write(temp + " ");
            Console.WriteLine();
        }
        private static int[] converStringToInt(string[] arr)
        {
            int[] sortArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sortArr[i] = int.Parse(arr[i]);
            }
            return sortArr;
        }
    }
}

