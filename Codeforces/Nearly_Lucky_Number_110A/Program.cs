using System;

namespace Nearly_Lucky_Number_110A
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            int count = 0;

            while(n != 0)
            { 
                if (n % 10 == 4 || n % 10 == 7)
                {
                    count += 1;
                }
                n /= 10;
            }
            if(count == 4 || count == 7)
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