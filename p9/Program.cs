using System;
using System.Text;

namespace p9
{
    internal class Program
    {
        static void Main()
        {
            string str;
            Console.Write("string: ");
            str = Console.ReadLine();
            char[] chars=str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write($"{chars[i]} ");
            }
            Console.WriteLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(chars);
            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write($"{asciiBytes[i]-97} ");
            }
            Console.WriteLine();
        }
    }
}
