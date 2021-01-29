using System;

namespace Task5
{
	class Program
	{
		enum Season
		{
			Winter,
			Spring,
			Summer,
			Autumn

		}
		enum Month
		{
			January,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December
		}

		static void Main(string[] args)
		{
			Season CurrentSeason;
			Month CurrentMonth;
			int NumberOfMonth;
			ConsoleColor color;

			do
			{
				NumberOfMonth = GetNumberOfMonth();
				GetTitle(NumberOfMonth, out CurrentMonth, out CurrentSeason, out color);
				OutSeason(CurrentMonth, CurrentSeason, color);
			} while (CheckRepeat());



		}

		static void OutSeason(Month CurrentMonth, Season CurrentSeason, ConsoleColor color)
		{
			WriteColor($"Now is {CurrentMonth}. It's {CurrentSeason}", color);
			Console.WriteLine();
		}

		static int GetNumberOfMonth()
		{
			Console.WriteLine("What is the number of month today?");
			int N = ReadInt();

			if (N < 1 || N > 12)
			{
				Console.WriteLine("Month number must be from 1 to 12 .Please re - enter");
				GetNumberOfMonth();
			}
			int n = N;
			return n;
		}

		static void GetTitle(int NumberOfMonth, out Month CurrentMonth, out Season CurrentSeason, out ConsoleColor color)
		{
			CurrentMonth = default;
			CurrentSeason = default;
			color = default;
			switch (NumberOfMonth)
			{
				case 1: CurrentMonth = Month.January; CurrentSeason = Season.Winter; color = ConsoleColor.White; break;
				case 2: CurrentMonth = Month.February; CurrentSeason = Season.Winter; color = ConsoleColor.White; break;
				case 3: CurrentMonth = Month.March; CurrentSeason = Season.Spring; color = ConsoleColor.Green; break;
				case 4: CurrentMonth = Month.April; CurrentSeason = Season.Spring; color = ConsoleColor.Green; break;
				case 5: CurrentMonth = Month.May; CurrentSeason = Season.Spring; color = ConsoleColor.Green; break;
				case 6: CurrentMonth = Month.June; CurrentSeason = Season.Summer; color = ConsoleColor.Yellow; break;
				case 7: CurrentMonth = Month.July; CurrentSeason = Season.Summer; color = ConsoleColor.Yellow; break;
				case 8: CurrentMonth = Month.August; CurrentSeason = Season.Summer; color = ConsoleColor.Yellow; break;
				case 9: CurrentMonth = Month.September; CurrentSeason = Season.Autumn; color = ConsoleColor.DarkYellow; break;
				case 10: CurrentMonth = Month.October; CurrentSeason = Season.Autumn; color = ConsoleColor.DarkYellow; break;
				case 11: CurrentMonth = Month.November; CurrentSeason = Season.Autumn; color = ConsoleColor.DarkYellow; break;
				case 12: CurrentMonth = Month.December; CurrentSeason = Season.Winter; color = ConsoleColor.White; break;
			}
		}
		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}


		static bool CheckRepeat()
		{
			ConsoleKeyInfo PressedKey;

			WriteColor("Press key 'Y' to repeat.", ConsoleColor.Gray);
			Console.WriteLine();

			PressedKey=Console.ReadKey();
			if (ConsoleKey.Y == PressedKey.Key)
			{
				Console.Clear();
				return true; 


			} return false;
		}
		static int ReadInt()
		{
			int IntNumber;
			while (!int.TryParse(Console.ReadLine(), out IntNumber))
			{
				WriteColor("Please input numerical data", ConsoleColor.Red);
				Console.WriteLine();
			}
			return IntNumber;
		}
	}
}

