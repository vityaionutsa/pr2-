using System;

class Program
{
    static void Main()
    {
        string[] str = new string[2];
        int i = 0,sum=0;
        for (i = 0; i < 2; i++)
        {
            str[i] = Console.ReadLine();
        }
        string[] words = str[0].Split(' ');
        string[] words1 = str[1].Split(' ');
        for(i=0;i<words.Length;i++)
        {
            for(int j=0;j<words1.Length;j++)
            {
                if (words[i].Contains(words1[j]))
                {
                    sum++;
                }
            }
        }
        Console.WriteLine(sum);
        Console.ReadLine();
    }
}