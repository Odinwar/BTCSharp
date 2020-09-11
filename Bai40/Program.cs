using System;
using System.Text.RegularExpressions;
/*
* Viết hàm số chèn một giá trị x vào một mảng đã sắp xếp tăng dần sao cho
* mảng đó vẫn sắp xếp tăng dần
*/
namespace Bai40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang  vao ngan cach bang dau cach : ");
            string[] input_arr = Regex.Split(Console.ReadLine(), "\\s+");
            int[] a = converStringToInt(input_arr);
            Console.WriteLine("Nhap  gia tri can chen : ");
            int value = int.Parse(Console.ReadLine());
            solution(ref a,value);
            foreach (int temp in a) Console.Write(temp + " ");
            Console.ReadKey();
        }

        static void solution(ref int[] a, int value)
        {
            int index =searchBinary(a, value);
            insert(ref a, index, value);
        }

        static int searchBinary(int[] a , int value)
        {
            return preSeachBinary(a, 0, a.Length - 1, value);
        }
        static int preSeachBinary(int[] a ,int first,int last,int value)
        {
            int mid = (first + last) / 2;
            if (a[mid] == value) return mid;
            if (a[first] >= value) return first;
            if (value < a[mid]) return preSeachBinary(a, first, mid - 1, value);
            if (value > a[last]) return last+1;
            return preSeachBinary(a, mid + 1, last, value);
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
            Array.Sort(sortArr);
            return sortArr;
        }
    }
}
