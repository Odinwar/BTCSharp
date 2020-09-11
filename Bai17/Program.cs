using System;
using System.Runtime.InteropServices;
/*
* Viết hàm tính giá trị biểu thức 1+2+3+....+n
*/
namespace Bai17
{
    class Program
    {
        static int result(int n)
        {
            return (n + n * (n - 1) / 2);
        }
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(result(a));
        }
    }
}
