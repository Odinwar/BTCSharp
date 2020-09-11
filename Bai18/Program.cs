using System;
/*
 *  Viết hàm tính giá trị biểu thức 1*2+2*3 + ... +(n-1)*n
 */
namespace Bai18
{
    class Program
    {
        static int result(int n)
        {
            int sum = 0;
            for(int i =2;i <= n; i++)
            {
                sum += i * i - 1;
            }
            return sum;
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
