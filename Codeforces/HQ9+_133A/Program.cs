using System;

namespace HQ9_133A
{
	class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();
			int flag = 0;
			for (int i = 0; i < str.Length; i++)
			{
				if (str[i] >= 33 && str[i] <= 126)
				{
					if (str[i] == 'H' || str[i] == 'Q' || str[i] == '9')
					{
						flag = 1;
					}
				}
			}
			if (flag != 0)
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