using System;
using System.Diagnostics.CodeAnalysis;
/*
* Viết hàm tính giá trị biểu thức x^1/1! + x^2/2! + ... x^n/n!
*/
namespace Bai20
{
    class Program
    {
        static int giaithua(int n)
        {
            if (n < 2) return 1;
            return n * (n - 1);
        }
        static double result(int x,int n)
        {
            double sum=0;
            for(int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, i) / giaithua(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int x,n;
            while (!int.TryParse(Console.ReadLine(), out x) | !int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(result(x,n));
        }
    }
}
