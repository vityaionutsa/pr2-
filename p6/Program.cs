using System;

namespace p6
{
    internal class Program
    {
        static void Main()
        {
            int[] arr = new int[20];
            int n,i;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            for(i=0;i<n;i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for(i=0;i<n;i++)
            {
                for(int j=i++;j<n;j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write($"{arr[j]} ");
                    }
                }
            }
        }
    }
}
