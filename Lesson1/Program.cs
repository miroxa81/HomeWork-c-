using System;

namespace Lesson1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("What is your name:");
			string name = Console.ReadLine();
			Console.WriteLine($"Hello {name}. Now is {DateTime.Now}.");
			Console.ReadKey();
		}
	}
}
