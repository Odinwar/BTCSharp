using System;
using System.Text.RegularExpressions;
/*
* Viết chương trình nhập vào một mảng số nguyên, in ra các giá trị số chẳn
* trong mảng đó
*/
namespace Bai32
{
    class Program
    {
            static void evenNumber(string[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int temp;
                    if (!int.TryParse(arr[i], out temp))
                    {
                        Console.WriteLine(arr[i] + " khong phai la so ");
                    } 
                    else if (temp % 2 == 0) Console.WriteLine(arr[i]);
                }
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Nhap cac gia tri mang vao ngan cach bang dau cach : ");
                string[] arr = Regex.Split(Console.ReadLine(), "\\s+");
                evenNumber(arr);
                Console.ReadKey();
            }
        
    }
}
