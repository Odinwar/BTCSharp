using System;
/*
 *  Viết chương trình nhập vào một số nguyên, kiểm tra số đó có phải là số nguyên tố
 */

namespace Bai15
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
            bool soNguyenTo = a < 0 ? false : true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0)
                {
                    soNguyenTo = false;
                    break;
                }
            }
            if (soNguyenTo) Console.WriteLine("Yes");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
