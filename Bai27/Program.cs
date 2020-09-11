using System;
/*
 * Viết chương trình nhập vào một chuổi gồm nhiều từ, in ra những từ trong chuổi đó, mỗi từ trên mỗi dòng
 */
namespace Bai27
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string temp in arr)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
