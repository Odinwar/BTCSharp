using System;
using System.Linq;
/*
* Viết hàm số đảo ngược các ký tự trong một chuổi
*/
namespace Bai25
{
    class Program
    {
        static string reverse(string s)
        {
            string result = "";
            for(int i = s.Length-1; i>=0; i--)
            {
                result += s[i]; 
            }
            return result;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(reverse(s));
        }
    }
}
