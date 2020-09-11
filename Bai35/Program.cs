using System;
using System.Text.RegularExpressions;
/*
*  Viết hàm số nối 2 mảng số nguyên thành 1 mảng duy nhất
*/
namespace Bai35
{
    class Program
    {
        static int[] converStringToInt(string[] arr)
        {
            int[] sortArr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                sortArr[i] = int.Parse(arr[i]);
            }
            return sortArr;
        }
        static int[] concatArr(int[] arr1,int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for(int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for(int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang 1 vao ngan cach bang dau cach : ");
            string[] arr1 = Regex.Split(Console.ReadLine(), "\\s+");
            Console.WriteLine("Nhap cac gia tri mang 2 vao ngan cach bang dau cach : ");
            string[] arr2 = Regex.Split(Console.ReadLine(), "\\s+");

            int[] a = converStringToInt(arr1);
            int[] b = converStringToInt(arr2);
            foreach (int temp in concatArr(a,b)) Console.Write(temp + " ");
            Console.ReadKey();
        }
    }
}
