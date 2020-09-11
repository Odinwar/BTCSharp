using System;
using System.Text.RegularExpressions;
/*
* . Viết hàm số tìm giá trị lớn nhất trong một mảng số nguyên
*/
namespace Bai31
{
    class Program
    {
        static int max(string[] arr)
        {
            int sum = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = Math.Max(int.Parse(arr[i]),sum);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang vao ngan cach bang dau cach : ");
            string[] arr = Regex.Split(Console.ReadLine(), "\\s+");
            Console.WriteLine(max(arr));
        }
    }
}
