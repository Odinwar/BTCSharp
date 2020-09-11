using System;
using System.Net;
/*
* Viết hàm số kiểm tra một năm có phải là năm nhuận không. (năm nhuận là
* năm chia hết cho 4, tuy nhiên nếu năm đó chia hết cho 100 thì cũng phải
*chia hết cho 400)
*/
namespace Bai23
{
    class Program
    {
        static string result(int n)
        {
            if (n % 4 - n % 100 != 0) return "YES";
            if (n % 100 - n % 400 == 0) return "YES";
            return "NO";
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Don't no number \n Please Try Again : ");
            }
            Console.WriteLine(result(n));
        }
    }
}
