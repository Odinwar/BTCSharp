using System;
/*
 * Viết chương trình nhập vào hệ số a, b, c. Giải phương trình ax^2 + bx + c = 0
 */
namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            while (!double.TryParse(Console.ReadLine(), out a) |
                !double.TryParse(Console.ReadLine(), out b) |
                !double.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("Input must number please try again : ");
            }
            double detal = b * b - 4 * a * c;
            double x1 = (-b - Math.Sqrt(detal)) / (2 * a);
            double x2 = (-b + Math.Sqrt(detal)) / (2 * a);

            Console.WriteLine("x1:{0}  x2: {1} ", x1, x2);
        }
    }
}
