using System;

namespace Bai24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            while (!double.TryParse(Console.ReadLine(), out a) | 
                !double.TryParse(Console.ReadLine(), out b) |
                !double.TryParse(Console.ReadLine(), out c)|  c < 0 | b < c | a < b | a < c)
            {
                Console.WriteLine("Input must number an 0<=c<=b<=a please try again : ");
            }
            for(int i = 1; i <= a/5; i++) { 
                Console.WriteLine("a : {0} b: {1} c: {2}", 5 * i, 4 * i, 3 * i);
            }
        }
    }
}
