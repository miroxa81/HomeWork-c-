using System;

namespace Task5
{
	class Program
	{

		enum Season
		{
			Spring,
			Summer,
			Autumn,
			Winter
		}
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

			string TitleOfMonth = "";
			Season CurrenSeason = Season.Autumn;
			int NumberOfMonth;
			do
			{
				Console.WriteLine("What is the number of month today?");
				NumberOfMonth = Convert.ToInt32(Console.ReadLine());
				if (NumberOfMonth < 1 && NumberOfMonth > 12)
				{
					Console.WriteLine("Month number must be from 1 to 12 .Please re - enter");
				}
				else
				{
					break;
				}
			} while (true); // проверка корректности ввоода номера месяца

			switch (NumberOfMonth) // определение названия месяца по номеру
			{
				case 12:
					TitleOfMonth = "December";
					CurrenSeason = Season.Winter;
					break;
				case 1:
					TitleOfMonth = "January";
					CurrenSeason = Season.Winter;
					break;
				case 2:
					TitleOfMonth = "February";
					CurrenSeason = Season.Winter;
					break;
				case 3:
					TitleOfMonth = "March";
					CurrenSeason = Season.Spring;
					break;
				case 4:
					TitleOfMonth = "April";
					CurrenSeason = Season.Spring;
					break;
				case 5:
					TitleOfMonth = "May";
					CurrenSeason = Season.Spring;
					break;
				case 6:
					TitleOfMonth = "June";
					CurrenSeason = Season.Summer;
					break;
				case 7:
					TitleOfMonth = "Jule";
					CurrenSeason = Season.Summer;
					break;
				case 8:
					TitleOfMonth = "August";
					CurrenSeason = Season.Summer;
					break;
				case 9:
					TitleOfMonth = "September";
					CurrenSeason = Season.Autumn;
					break;
				case 10:
					TitleOfMonth = "October";
					CurrenSeason = Season.Autumn;
					break;
				case 11:
					TitleOfMonth = "November";
					CurrenSeason = Season.Autumn;
					break;
			}

			switch (CurrenSeason) // вывод месяца и времени года 
			{
				case Season.Winter:
					{
						Console.ForegroundColor = ConsoleColor.White;
						if (AvTemp > 0)
						{
							Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
							Console.WriteLine($"It's a rainy winter in {TitleOfMonth} this year.");
						}
						else
						{
							Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
						}
					}
					Console.ResetColor();
					break;

				case Season.Spring:
					Console.ForegroundColor = ConsoleColor.Green;
					{
						Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
					}
					Console.ResetColor();
					break;

				case Season.Summer:
					Console.ForegroundColor = ConsoleColor.Yellow;
					{
						Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
					}
					Console.ResetColor();
					break;
				case Season.Autumn:
					{
						Console.ForegroundColor = ConsoleColor.DarkYellow;
						Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
					}
					Console.ResetColor();
					break;
			}
			Console.ReadKey();
		}
	}
}
