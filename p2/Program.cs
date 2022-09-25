using System;



    class Program
    {
    static void Main()
    {
        int[] arr = new int[20];
        int[] b = new int[20];
        int[] res = new int[20];
        int k,t,n;
        int nextInd = 0;
        Console.Write("n = ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("k = ");
        k = Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
            b[i] = arr[i];
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write($"{b[i]} ");
        }

        for (int i = 0; i < n - 1; ++i)
        {
            nextInd += k;
            nextInd %= n;

            t = arr[nextInd];
            arr[nextInd] = arr[0];
            arr[0] = t;
        }
        Console.WriteLine();
        for (int i= 0; i < n;i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
        for(int i=0;i<n;i++)
        {
            res[i] = arr[i] + b[i];
            Console.Write($"{res[i]} ");
        }
    }
    }

