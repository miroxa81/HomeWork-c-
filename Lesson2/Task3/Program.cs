using System;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			int Number;
			Console.WriteLine("Please, enter any number:");
			if (!Int32.TryParse(Console.ReadLine(), out Number))
			{
				Console.WriteLine("Please, enter only number, not text:");
			}
			else
			{
				if (Number % 2 == 0)
				{
					Console.WriteLine($"Number {Number} is even!");
				}
				else
				{
					Console.WriteLine($"Number {Number} is odd!");
				}
			}
			Console.ReadKey();
		}
	}
}
