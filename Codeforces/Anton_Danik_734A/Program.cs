using System;

namespace Anton_Danik_734A
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < a; i++)
            {
                if(s[i] == 'A')
                    count1++;
                else if(s[i] == 'D')
                    count2++;            }
            if (count1 > count2)
                Console.Write("Anton");
            else if (count1 < count2)
                Console.Write("Danik");
            else if (count1 == count2)
                Console.Write("Friendship");
        }
    }
}