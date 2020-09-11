using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số tìm một số nguyên từ một mảng số nguyên và trả về vị trí tìm
* thấy, ngược lại trả về -1 nếu không tìm thấy
*/
namespace Bai34
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
        static int searchBinary(int[] arr, int x)
        {
            return preSearchBinary(arr,0,arr.Length-1,x);
        }
        static int preSearchBinary(int[] arr,int first,int last,int x)
        {
            if (first > last) return -1;
            int mid = (first + last) / 2;
            if (arr[mid] == x) return mid;
            else if (arr[mid] < x) return preSearchBinary(arr, mid + 1, last, x);
            else return preSearchBinary(arr, first, mid - 1, x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang vao ngan cach bang dau cach : ");
            string[] a = Regex.Split(Console.ReadLine(), "\\s+");
            int[] arr = converStringToInt(a);
            Console.WriteLine("\nMang sau khi sap xep :");
            foreach (int temp in arr) Console.Write(temp + " ");
            Console.WriteLine("Nhap gia tri tim kiem : ");
            int x = int.Parse(Console.ReadLine());   
            Console.WriteLine(searchBinary(arr, x));
            Console.ReadKey();
        }
    }
}
