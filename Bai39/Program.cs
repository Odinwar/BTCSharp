using System;
using System.Text.RegularExpressions;
/*
 * Viết hàm số xóa một phần tử trong mảng
 */
namespace Bai39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            Console.WriteLine("Nhap vi tri can xoa : ");
            string[] index_value = Regex.Split(Console.ReadLine(), "\\s+");
            int index = int.Parse(index_value[0]);
            delete(ref a, index);
            foreach (int temp in a) Console.Write(temp + " ");
            Console.ReadKey();
        }

        static void delete(ref int[] a, int index)
        {
            if (index > a.Length-1 ) throw new Exception("Index error !");
            else
            {
                int[] arr = a;
                a = new int[a.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    a[i] = arr[i];
                }
                for (int i = index; i < a.Length; i++)
                {
                    a[i] = arr[i + 1];
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
