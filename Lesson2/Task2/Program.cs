using System;

namespace Task2
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
			string TitleOfMonth = "";
			Season CurrenSeason = Season.Autumn;
			int NumberOfMonth;

			do
			{
				Console.WriteLine("What is the number of month today?");

				if (Int32.TryParse(Console.ReadLine(), out NumberOfMonth))
				{
					if (NumberOfMonth < 1 || NumberOfMonth > 12)
					{
						Console.WriteLine("Month number must be from 1 to 12 .Please re - enter");
					}
					else
					{
						break;
					}

				}
				else
				{
					Console.WriteLine("Please enter digits from 1 to 12");
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
						Console.WriteLine($"Now is {TitleOfMonth}. It's {CurrenSeason}.");
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
