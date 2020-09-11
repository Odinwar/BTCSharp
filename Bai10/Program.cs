using System;
using System.Threading;
/*
* Viết chương trình nhập một số nguyên n và vẽ ra tam giác với các ký tự  gồm n dòng như sau (ví dụ n= 6)
*/

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Don't no number or number bigger than 0 \n Please Try Again : ");
            }
            int star = 1;
            int row = 0;
            while(star < n * 2)
            {
                for(int i = 0; i < n - row; i++)
                {
                        Console.Write(" ");
                }
                for (int i = 0; i < star; i++)
                {
                        Console.Write("*");
                }
                star += 2;
                row++;
                Console.WriteLine();
            }
        }
    }
}
