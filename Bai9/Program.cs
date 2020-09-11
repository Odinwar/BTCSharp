using System;
/*
 * Viết 1 biểu thức điều kiện để lấy giá trị lớn nhất trong 3 số a, b, c
 */
namespace Bai9
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
            double max = a > b ? a : b;
            max = max > c ? max : c;
            Console.WriteLine(max);
        }
    }
}
