using System;
/*
 * Viết hàm số tính số fibonaci thứ n
 */
namespace Bai22
{
    class Program
    {
        static int  fibonaci(int n)
        {
            if (n == 1 || n == 2) return 1;
            return fibonaci(n - 1) + fibonaci(n - 2); 
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(fibonaci(n));
        }
    }
}
