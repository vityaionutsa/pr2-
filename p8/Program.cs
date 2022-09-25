using System;

namespace p8
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[100];
            int n, max, m;
            int[] a = new int[10];
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            for(int i=0;i<9;i++)
            {
                a[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                switch (arr[i])
                {
                    case 0:
                        a[0]++;
                        break;
                    case 1:
                        a[1]++;
                        break;
                    case 2:
                        a[2]++;
                        break;
                    case 3:
                        a[3]++;
                        break;
                    case 4:
                        a[4]++;
                        break;
                    case 5:
                        a[5]++;
                        break;
                    case 6:
                        a[6]++;
                        break;
                    case 7:
                        a[7]++;
                        break;
                    case 8:
                        a[8]++;
                        break;
                    case 9:
                        a[9]++;
                        break;
                }
            }
            m = 0;
            max = a[0];
            for (int i = 0; i < 9; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    m = i; 
                }
            }
            Console.WriteLine();
            Console.WriteLine(m);
        }
    }
}
