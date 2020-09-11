using Microsoft.VisualBasic.FileIO;
using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số chèn một số nguyên vào một mảng số nguyên vào trị trí nhất định
*/
namespace Bai37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            Console.WriteLine("Nhap vi tri can chen va gia tri ngang cach bang dau cach : ");
            string[] index_value = Regex.Split(Console.ReadLine(), "\\s+");
            int index = int.Parse(index_value[0]);
            int value = int.Parse(index_value[1]);
            insert(ref a, index, value);
            foreach (int temp in a) Console.Write(temp + " ");
            Console.ReadKey();
        }

        static void insert(ref int[] a, int index, int value)
        {
            if (index > a.Length) throw new Exception("Index error !");
            else
            {
                int[] arr = a;
                a = new int[a.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    a[i] = arr[i];
                }
                a[index] = value;
                for (int i = index + 1; i < a.Length; i++)
                {
                    a[i] = arr[i - 1];
                }
            }
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

