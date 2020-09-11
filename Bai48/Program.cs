using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
/*
*  Chọn một phần tử bất kỳ trong dãy số và kiểm tra xem nó có phải là số
*  nguyên tố không và liệt kê các phần tử trong dãy là số nguyên tố và bé 
*  hơn phần tử vừa chọn.
*/
namespace Bai48
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = nhap();
            xuat(arr);
             
            Console.WriteLine("Nhap vi tri bat ky trong mang");
            int index;
            while(!int.TryParse(Console.ReadLine(),out index) | index <0 | index >(arr.Length-1))
            {
                Console.WriteLine("vui long nhap lai , dau vao phai la so tu 0 --- >{0}: ",arr.Length-1);
            }
            List<int> list = solution(arr,index);
            String s = songuyento(arr[index]) ? "YES" : "NO";
            Console.WriteLine(s);
            if (list.Count == 0) Console.WriteLine("Khong co gia tri nao la so nguyen to be hon {0}", arr[index]);
            else  foreach (int temp in list) Console.WriteLine(temp);
        }

        private static dynamic solution(int[] arr,int index)
        {
            var list =new  List<int>();
            
            foreach(int temp in arr) 
            {
                if ((temp < arr[index]) && songuyento(temp)) list.Add(temp);
            }
            return list;
        }

        private static bool songuyento(int temp)
        {
            if (temp < 2) return false;
            for(int i = 2; i<= Math.Sqrt(temp); i++)
            {
                if (temp % i == 0) return false;
            }
            return true;
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
