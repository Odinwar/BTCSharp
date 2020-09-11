using System;
/*
 * Viết chương trình nhập vào một số nguyên, in ra chữ số lớn nhất trong số nguyên đó.
 */
namespace Bai13
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
            int max = a % 10;
            while(a > 0)
            {
                max = max > (a % 10) ? max : (a % 10);
                a = a / 10;
            }
            Console.WriteLine(max);
        }
    }
}
