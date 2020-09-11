using System;
/*
 * Viết chương trình nhập vào 2 số nguyên, in ra ước chung lớn nhất và bội chung lớn nhất của 2 số đó.
 */
namespace Bai11
{
    class Program
    {
        static int gcd(int a, int b){
            if (a % b == 0) return b;
            return gcd(b, a % b);
        }
        static int lcm(int a , int b)
        {
            return (a * b) / gcd(a, b);
        }
        static void Main(string[] args)
        {
            int a,b;
            while (!int.TryParse(Console.ReadLine(), out a) | !int.TryParse(Console.ReadLine(),out b))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine("UCLN:"+gcd(a, b));
            Console.WriteLine("BCNN:"+lcm(a, b));
        }
    }
}
