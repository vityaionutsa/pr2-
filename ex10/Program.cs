
using System;


namespace ex10
{
    internal class Program
    {
        static void Main()
        {
            int[] a = new int[20];
            int n, k,m,sum;
            Console.Write("n = ");
            n=Convert.ToInt32(Console.ReadLine());
            Console.Write("k = ");
            k=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            m = 0;
            sum = 0;
            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if (a[i] + k == a[j])
                    {
                        sum++;
                    }
                }
                
            }
            Console.WriteLine($"out = {sum}");
        }
    }
}
