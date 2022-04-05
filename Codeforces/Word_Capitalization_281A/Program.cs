using System;

namespace Word_Capitalization_281A
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            if (char.IsLower(s[0]))
            {
                Console.Write(char.ToUpper(s[0]));
                Console.WriteLine(s.Substring(1, s.Length - 1));
            }
            else
            {
                Console.WriteLine(s);
            }

        }
    }
}