using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số kiểm tra một mảng có phải là mảng đối xứng
*/
namespace Bai41
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            String s = solution(a) ? "Yes" : "No";
            Console.Write(s);
            Console.ReadKey();
        }

        static bool solution(int[] a)
        {
            for(int i = 0; i < a.Length / 2; i++)
            {
                if (a[i] != a[a.Length - i -1]) return false;      
            }
            return true;
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
