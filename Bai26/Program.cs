using System;
using System.Text;
/*
* Viết chương trình nhập vào một chuổi gồm nhiều từ, đổi tất cả các ký tự đầu
* từ thành chữ hoa và in ra màn hình. Ví dụ nhập “ho van ten” đổi thành “Ho Van Ten”
*/
namespace Bai26
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder(Console.ReadLine());
            if (s[0] - 32 > 65) s[0] -= (char)32;
            for(int i = 1; i < s.Length; i++)
            {
                if (s[i] != ' ' && s[i - 1] == ' ') {
                    int temp = s[i] - 32;
                    if (temp >= 65) s[i] = (char)temp; 
                }
            }
            Console.WriteLine(s.ToString());
        }
    }
}
