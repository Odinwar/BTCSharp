using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số nối 2 mảng số nguyên thành một mảng duy nhất, 2 mảng gốc
* đã được sắp xếp tăng dần và đảm bảo mảng kết quả cũng phải được sắp xếp tăng dần
*/
namespace Bai36
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
            Array.Sort(sortArr);
            return sortArr;
        }
        static int[] concatArr(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                result[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                result[arr1.Length + i] = arr2[i];
            }
            Array.Sort(result);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang 1 vao ngan cach bang dau cach : ");
            string[] arr1 = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(arr1);
            Console.WriteLine();
            Console.WriteLine("Mang sau khi sap xep :");
            foreach (int temp in a) 
                Console.Write(temp + " ");
            Console.WriteLine();
            Console.WriteLine("Nhap cac gia tri mang 2 vao ngan cach bang dau cach : ");
            string[] arr2 = Regex.Split(Console.ReadLine(), "\\s+");
            int[] b = converStringToInt(arr2);
            Console.WriteLine("Mang sau khi sap xep :");
            foreach (int temp in a)
                Console.Write(temp + " ");
            Console.WriteLine();
            Console.WriteLine("Mang noi lai va sap xep : ");
            foreach (int temp in concatArr(a, b)) Console.Write(temp + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
