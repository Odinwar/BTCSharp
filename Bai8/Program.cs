using System;
using System.Net.Sockets;
/*
* Viết chương trình nhập vào điểm tổng kết hệ 10 của một sinh viên, in ra điểm hệ số A B C D F. Biết rằng điểm từ :
* 0 -- 3.9 là F
* 4 – 5.4 là D
* 5.5 – 6.4 là C
* 6.5 — 8 là B
* 8 – 10 là A
*/

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = -1;
            while (!Double.TryParse(Console.ReadLine(), out score) || score <0 || score > 10)
            {
                Console.WriteLine("Don't no number or number bigger than 0 \n Please Try Again : ");
            }
            string s = "";
            if (score < 3.9) s = "F";
            else if (score < 5.4) s = "D";
            else if (score < 6.4) s = "C";
            else if (score < 8) s = "B";
            else s = "A";
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
