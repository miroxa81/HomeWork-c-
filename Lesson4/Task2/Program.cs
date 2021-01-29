using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input numbers separated by space:");
			ConsoleKeyInfo PressedKey;

			float sum = 0;

<<<<<<< HEAD
			string[] Line = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
=======
			string[] Line = Console.ReadLine().Split(new char[] { ' ' });
>>>>>>> Lesson4

			total(Line, ref sum);

			WriteDarkGreen($"{Convert.ToString(sum)}");
		}
		static void total(string[] Line, ref float sum)
		{
			string unit;
			for (int i = 0; i < Line.Length; i++)
			{
				unit = Line[i];

				if (float.TryParse(unit, out float number))
				{
					sum += number;
				}
			}
		}
		static void WriteDarkGreen(string txt)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write(txt);
			Console.ResetColor();
		}
	}
}
