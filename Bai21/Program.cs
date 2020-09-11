using System;
/*
 *  Viết hàm số đảo giá trị của 2 số nguyên
 */
namespace Bai21
{
    class Program
    {
        static void swap(ref int a, ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            while (!int.TryParse(Console.ReadLine(), out a) | !int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            swap(ref a, ref b);
            Console.WriteLine(a + " " + b);
        }
    }
}
