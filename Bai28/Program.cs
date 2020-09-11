using System;
using System.Text.RegularExpressions;
/*
* Viết chương trình nhập vào một chuổi, in ra các ký tự hoa đã nhập trong chuổi
*/
namespace Bai28
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Regex.Split(Console.ReadLine(),"[^A-Z]*");
            foreach (string temp in arr)
            {
                if(temp != "") Console.WriteLine(temp);
            }
        }
    }
}
