using System;

namespace p4
{
    internal class Program
    {
        static void Main()
        {
            int n,m=2;
            Console.Write("n = ");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (((m * m) % 24 == 1 && m%5!=0)||m==2||m==3||m==5)
                {
                    Console.WriteLine($"{m} ");
                }
                m++;
            }
        }
    }
}
