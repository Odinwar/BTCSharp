using System;
/*
 * Viết hàm tính giá trị biểu thức 4 . (1 - 1/3 +1/5 -1/9 +1/11 + .... +(-1)^((n-1)/2)/n 
 */
namespace Bai19
{
    class Program
    {
        static double result(int n)
        {
            double sum = 0;
            int i=1;
            int j=3;
            do
            {
                Console.Write(i + " -" + j+" ");
                sum += j <= n ? (1.0 / i - 1.0 / j) : 1.0 / i;
                i = j + 2;
                j = i + 4;
               
            } while (i <= n);
            return 4*sum;
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
