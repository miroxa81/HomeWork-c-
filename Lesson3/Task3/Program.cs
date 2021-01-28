using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Plese enter any text:");
			string str = Console.ReadLine();
			Console.WriteLine("---------------------");
			Console.Write("Backwards:");
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			for (int i = str.Length - 1; i >= 0; i--)
			{
				Console.Write(str[i]);
			}
			Console.ResetColor();
			Console.ReadKey();
		}
	}
}
