using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số tìm xem trong một mảng các số nguyên, số nào xuất hiện nhiều nhất
*/
namespace Bai42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            Console.Write(solution(a));
            Console.ReadKey();
        }

        static int solution(int[] a)
        {
            int[] num = new int[100];
            for (int i = 0; i < a.Length; i++)
            {
                int temp = a[i];
                num[temp]++;
            }
            int index = -1;
            int max = -1;
            for (int i = 0; i<num.Length; i++)
            {
                if (max < num[i]) 
                {
                    max = num[i];
                    index = i;
                }
            }
            return index; 
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
