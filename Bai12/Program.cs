using System;
/*
 * Viết chương trình nhập vào một số nguyên, in ra số đó ở dạng nhị phân
 */
namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(Convert.ToString(a,2));
        }
    }
}
