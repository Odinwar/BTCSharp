using System;
using System.Text.RegularExpressions;

namespace Bai33
{
    class Program
    {
        static void sortArr(string[] arr)
        {
            double[] sortArr = new double[arr.Length];
            for(int i = 0; i < arr.Length; i++) {
                sortArr[i] = double.Parse(arr[i]);
            }
            Array.Sort(sortArr);
            foreach(double temp in sortArr){
                Console.Write(temp + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac gia tri mang vao ngan cach bang dau cach : ");
            string[] arr = Regex.Split(Console.ReadLine(), "\\s+");
            sortArr(arr);
            Console.ReadKey();
        }
    }
}
