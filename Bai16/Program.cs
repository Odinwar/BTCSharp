using System;
using System.Diagnostics.CodeAnalysis;
/*
* Viết chương trình nhập vào số nguyên dương n, in ra giai thừa của n
*/
namespace Bai16
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
            int sum = 1;
            do
            {
                sum *= a;
            } while ((a--) > 1);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
