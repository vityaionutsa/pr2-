using System;

namespace p5
{
    internal class Program
    {
        static void Main()
        {
            char[] chars = new char[20];
            char[] chars1 = new char[20];
            int i = 0, n = 3;
            string str="",str1="";
            Console.Write("char[1]: ");
            for (i = 0; i < n; i++)
            {
                chars[i] = Convert.ToChar(Console.ReadLine());
            }
            Console.Write("char[2]: ");
            for (i = 0; i < n; i++)
            {
                chars1[i] = Convert.ToChar(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (Convert.ToByte(chars[i]) < Convert.ToByte(chars1[i]))
                {
                    for (i = 0; i < n; i++)
                    {
                        str += Convert.ToString(chars[i]);
                    }
                    for (i = 0; i < n; i++)
                    {
                        str1 += Convert.ToString(chars1[i]);
                    }
                    Console.WriteLine(str);
                    Console.WriteLine(str1);
                    break;
                }
                if (Convert.ToByte(chars[i]) > Convert.ToByte(chars1[i]))
                {
                    for (i = 0; i < n; i++)
                    {
                        str += Convert.ToString(chars[i]);
                    }
                    for (i = 0; i < n; i++)
                    {
                        str1 += Convert.ToString(chars1[i]);
                    }
                    Console.WriteLine(str1);
                    Console.WriteLine(str);
                    break;
                }
                    
                
            }
        }
    }
}
