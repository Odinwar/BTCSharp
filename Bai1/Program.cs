using System;
/*
 * Viết chương trình nhập vào một số tiền dollar $, in ra số tiền VND tương ứng
 * biết rằng mỗi dollar $ tương ứng 22000 VND
 */
namespace Bai1
{
    class Program
    {
        static void Main(String[] args)
        {
            double dollar;
            while (!Double.TryParse(Console.ReadLine(), out dollar))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(dollar + " $ --> VND : " + (dollar * 22e3));
            Console.ReadKey();
        }
    }
}
