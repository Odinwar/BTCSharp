using System;
/*
 * Viết chương trình nhập vào một số nguyên, in ra màn hình số đó là số chẳn hay số lẽ
*/
namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while(!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Input must number please try again : ");
            }
            string result = n % 2 == 0 ? "So chan" : "So le";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
