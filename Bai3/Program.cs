using System;
/*
 * Viết chương trình nhập vào số đo độ của 1 góc, đổi số đo đó sang radian.
 */
namespace Bai3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double deg;
            while (!Double.TryParse(Console.ReadLine(), out deg))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            double radian = deg * Math.PI / 180;
            Console.WriteLine(deg + " Deg --> Radian : " + radian);
            Console.ReadKey();
        }
    }
}
