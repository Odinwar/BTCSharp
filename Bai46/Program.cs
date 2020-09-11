using System;
using System.Text.RegularExpressions;
/*
*   Tính tích các số chẵn và tổng các phần tử ở vị trí lẻ
*/
namespace Bai46
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = nhap();
            xuat(arr);
            int[] result = solution(arr);
            Console.WriteLine("Tich cac so chan : {0} Tong cac phan tu o vi tri le: {1}",result[0],result[1]);
        }

        private static int[] solution(int[] arr)
        {
            int[] result = { 1, 0 };
            for(int i = 0; i< arr.Length;i++)
            {
                if (arr[i] % 2 == 0) result[0] *= arr[i];
                if (i%2 !=0) result[1] += arr[i];
            }
            return result;
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

