using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*
* Hàm sắp xếp các phần tử trong dãy số nguyên (tùy chọn).
*/
namespace Bai44
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = nhap();
            xuat(arr);
            quickSort(ref arr);
            xuat(arr);
            quickSort(ref arr, true);
            xuat(arr);
            quickSort(ref arr, 0, 4);
            xuat(arr);
        }

        private static void quickSort(ref int[] arr, bool revese = false)
        {
            preQuickSort(ref arr, 0, arr.Length - 1, revese);
        }
        private static void quickSort(ref int[] arr, int start, int end, bool revese = false)
        {
            preQuickSort(ref arr, start, end, revese);
        }

        private static void preQuickSort(ref int[] arr, int first, int last, bool revese)
        {
            if (first >= last) return;
            int mid = (first + last) / 2;
            int i = first;
            int j = last;
            do
            {
                if (!revese)
                {
                    while (arr[i] < arr[mid]) i++;
                    while (arr[j] > arr[mid]) j--;
                }
                else
                {
                    while (arr[i] > arr[mid]) i++;
                    while (arr[j] < arr[mid]) j--;
                }
                if (i <= j)
                {
                    swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i <= j);
            preQuickSort(ref arr, first, j, revese);
            preQuickSort(ref arr, i, last, revese);
            return;
        }

        private static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
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
