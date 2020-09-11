using System;
using System.Text.RegularExpressions;
/*
*  Viết hàm số tính tổng của các số trong một mảng số nguyên
*/
namespace Bai30
{
    class Program
    {
        static int sum(string[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += int.Parse(arr[i]);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang vao ngan cach bang dau cach : ");
            string[] arr = Regex.Split(Console.ReadLine(), "\\s+");
            Console.WriteLine(sum(arr));
        }
    }
}
