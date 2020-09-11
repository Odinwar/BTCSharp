using System;

/*
 * Viết chương trình nhập vào nhiệt độ ở độ C, in ra nhiệt độ ở độ F biết rằng
 * công thức chuyển đổi là °F = (°C × 1.8) + 32
*/

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            double do_C;
            while (!Double.TryParse(Console.ReadLine(), out do_C))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(do_C + " C --> F : " + (do_C * 1.8 + 32));
            Console.ReadKey();
        }
    }
}
