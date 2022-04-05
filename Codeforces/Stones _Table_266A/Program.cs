using System;

namespace Stones_Table_266A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int r = 0;
            int g = 0;
            int b = 0;
            for (int i = 1; i < n; i++)
            {
                if (s[i - 1] == s[i])
                {
                    if (s[i] == 'R')
                    {
                        ++r;
                    }
                    else if (s[i] == 'G')
                    {
                        ++g;
                    }
                    else if (s[i] == 'B')
                    {
                        ++b;
                    }
                }
            }
            Console.Write(r + g + b);
        }
	}
}