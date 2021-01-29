using System;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			ConsoleColor color;
			Console.WriteLine("Please input number:");
			int N = ReadInt();
			WriteColor($"In the Fibonacci sequence, the ", ConsoleColor.DarkGreen);
			WriteColor($"{N}th ", ConsoleColor.Green);
			WriteColor($"number is ", ConsoleColor.DarkGreen);
			WriteColor($"{Fib(N)}", ConsoleColor.Green);
		}
		static int Fib(int N)
		{
			if (N == 1 || N == 0)
			{
				return N;
			}
			else
			{
				return Fib(N - 1) + Fib(N - 2);
			}
		}
		static int ReadInt()
		{
			int IntNumber;
			while (!int.TryParse(Console.ReadLine(), out IntNumber))
			{
				WriteColor("Please input numerical data", ConsoleColor.Gray);
				Console.WriteLine();
			}
			return IntNumber;
		}

		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}
}
