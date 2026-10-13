
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            int count = 0;
            int found = 0;

            for (int j = 0; j < s.Length; j++)
            {
                if (s[i] == s[j])
                    count++;
            }

            for (int k = 0; k < i; k++)
            {
                if (s[i] == s[k])
                    found = 1;
            }

            if (count > 1)
            {
                if (found == 0)
                {
                    Console.WriteLine(s[i] + " = " + count);
                }
            }
        }
    }
}
