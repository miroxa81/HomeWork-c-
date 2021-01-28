using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input numbers separated by space:");
			string number ="";
			string Line = "12 33 43 2 1 3 5 76 -3 12 5";
			int sum=0;

			for (int i = 0; i < Line.Length; i++)
			{
				if (!char.IsWhiteSpace(Line[i]))
				{
					number += Line[i];
				}
				else
				{
					sum += int.Parse(number);
					number = "";
				}
			}
			WriteDarkGreen($"{sum}");
		}

		static void WriteDarkGreen(string txt)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write(txt);
			Console.ResetColor();

		}
	}
}
