using System;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;
/*
*  Viết hàm số chuyển tất cả các số chẳn về bên trái và tất cả các số lẻ về bên
* phải của một mảng.
*/
namespace Bai38
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            solution(ref a);
            foreach (int temp in a) Console.Write(temp + " ");
            Console.ReadKey();
        }

        static void solution(ref int[] a)
        {
            int first = 0;
            int last = a.Length-1;
            while (first <= last)
            {
                while (a[first] % 2 == 0)
                {
                    first++;
                }
                while (a[last] % 2 != 0)
                {
                    last--;
                }
                if (first > last) break;
                swap(ref a[first], ref a[last]);
            }
        }

        static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        static int[] converStringToInt(string[] arr)
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
