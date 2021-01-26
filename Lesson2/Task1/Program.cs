using System;

namespace Task1
{
	class Program
	{

		static void Main(string[] args)
		{

			int tMin, tMax;

			do
			{
				do
				{
					Console.WriteLine($"What is the minimum temperature today?");
					if (!Int32.TryParse(Console.ReadLine(), out tMin))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Please enter a value in numbers");
						Console.ResetColor();
					}
					else
					if (tMin < -70)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("This is unreal temperature for the Earth. Let's re-enter.");
						Console.ResetColor();
					}
					else
					{
						break;
					}

				} while (true); // проверка корректной минимальной температуры

				do
				{
					Console.WriteLine("What is the maximum temperature today?");

					if (!Int32.TryParse(Console.ReadLine(), out tMax))
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("Please enter a value in numbers");
						Console.ResetColor();
					}
					else
					if (tMax > 60)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("This is unreal temperature for the Earth. Please re-enter.");
						Console.ResetColor();
					}
					else
					{
						break;
					}



				} while (true); // проверка корректной максимальной температуры


				if (tMax < tMin)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine($"The maximum temperature cannot be less than the minimum temperature.");
					Console.WriteLine($"Both values must be entered again!");
					Console.ResetColor();
				}
				else
				{
					break;
				}
			} while (true); // проверка правильности ввода мин/макс

			int AvTemp = (tMin + tMax) / 2; // вычисление средней температуры за день

			if (AvTemp <= 0)
			{
				Console.ForegroundColor = ConsoleColor.Cyan;
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
			}

			Console.WriteLine($"Average temperature today:{AvTemp}");
			Console.WriteLine("");
			Console.ResetColor();
			Console.ReadKey();

		}
	}
}
