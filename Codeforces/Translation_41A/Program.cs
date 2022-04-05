using System;

namespace Translation_41A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string s = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                s += str[i];
            }
            string t = Console.ReadLine();

            if (s == t)
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}