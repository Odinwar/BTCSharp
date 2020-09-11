using System;
using System.Text.RegularExpressions;
/*
* Viết chương trình nhập vào một mảng số nguyên, in ra các giá trị số chẳn
trong mảng đó
*/
namespace Bai29
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double result = 0;
            for(int i = 0; i < s.Length; i++) {
                switch (s[i]) {
                    case '+':
                        result = double.Parse(s.Substring(0, i).Trim()) + double.Parse(s.Substring(i + 1, s.Length - (i + 1)));
                        break;
                    case '-':
                        result = double.Parse(s.Substring(0, i).Trim()) - double.Parse(s.Substring(i + 1, s.Length - (i + 1)));
                        break;
                    case '*':
                        result = double.Parse(s.Substring(0, i).Trim()) * double.Parse(s.Substring(i + 1, s.Length - (i + 1)));
                        break;
                    case '/':
                        result = double.Parse(s.Substring(0, i).Trim()) / double.Parse(s.Substring(i + 1, s.Length - (i + 1)));
                        break;
                    default: continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
