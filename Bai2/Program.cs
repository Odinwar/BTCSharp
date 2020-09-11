using System;
/*
 * Viết chương trình nhập vào điểm 3 môn toán, lý, hóa, in ra điểm trung bình ba môn .
 */
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            double toan, ly, hoa; 
            while(!double.TryParse(Console.ReadLine(),out toan) |
                !double.TryParse(Console.ReadLine(), out ly) |
                !double.TryParse(Console.ReadLine(), out hoa))
            {
                Console.WriteLine("Input must number please try again : ");
            }
            double avg = (toan + ly + hoa) / 3;
            Console.WriteLine(avg);
            Console.ReadKey();
        }
    }
}
