using System;
/*
 * Viết chương trình nhập vào 3 số thực, kiểm tra xem 3 số thực đó có phải là độ dài 3 cạnh của một tam giác
 */
namespace Bai7
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
            if (a + b - c > 0 && a + c - b > 0 && b + c - a > 0) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}
