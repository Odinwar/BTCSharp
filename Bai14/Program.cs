using System;
/*
 * Viết chương trình nhập vào một số nguyên dương, in ra số có các chữ số
 * được viết theo thứ tự ngược lại. Ví dụ nhập vào số 6752 in ra số 2576
 */

namespace Bai14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            do
            {
                Console.Write(a % 10);
            } while ((a = a / 10) > 0);
        }
    }
}
