using System;
using System.Text.RegularExpressions;
/*
* Sắp xếp dãy số theo hình mái ngói 
* 1-Tìm phần tử lớn nhất trong dãy, 
* 2-Thay đổi vị trí phần tử ở giữa và phần tử lớn nhất,
* 3-Chọn phần tử ở giữa làm tâm, sắp xếp theo thứ tự giảm dần về hai phía)
*/
namespace Bai47
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = nhap();
            xuat(arr);
            solution(ref arr);
            xuat(arr);
        }

        private static void solution(ref int[] arr)
        {
            int max = arr[0];
            int index = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(max < arr[i])
                {
                    max = arr[i];
                    index = i;
                }
            }
            swap(ref arr[index],ref arr[arr.Length / 2]);
            quickSort(ref arr, 0, arr.Length / 2 - 1);
            quickSort(ref arr, arr.Length/2 + 1, arr.Length - 1, true);
        }

        private static void quickSort(ref int[] arr, int start, int end, bool revese = false)
        {
            preQuickSort(ref arr, start, end, revese);
        }

        private static void preQuickSort(ref int[] arr, int first, int last, bool revese)
        {
            if (first >= last) return;
            int mid = (first + last) / 2;
            int i = first;
            int j = last;
            do
            {
                if (!revese)
                {
                    while (arr[i] < arr[mid]) i++;
                    while (arr[j] > arr[mid]) j--;
                }
                else
                {
                    while (arr[i] > arr[mid]) i++;
                    while (arr[j] < arr[mid]) j--;
                }
                if (i <= j)
                {
                    swap(ref arr[i], ref arr[j]);
                    i++;
                    j--;
                }
            } while (i <= j);
            preQuickSort(ref arr, first, j, revese);
            preQuickSort(ref arr, i, last, revese);
            return;
        }

        private static void swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
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
