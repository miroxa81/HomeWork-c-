using System;

namespace Task6
{
	class Program
	{

		[Flags]
		public enum Days
		{
			Monday = 0b_0000001,
			Tuesday = 0b_0000010,
			Wednesday = 0b_0000100,
			Thursday = 0b_0001000,
			Friday = 0b_0010000,
			Saturday = 0b_0100000,
			Sunday = 0b_1000000,
			WorkDasy = Monday | Tuesday | Wednesday | Thursday | Friday,
			Weekdays = Saturday | Sunday
		}

		static void Main(string[] args)
		{



			Days OpenOffice1 = (Days)0b_0011110;
			Days OpenOffice2 = (Days)0b_1111000;
			bool isOpenOffice1 = false;
			bool isOpenOffice2 = false;
			DateTime dd;


			Console.WriteLine($"Timetable first office:\n" +
				$"Monday    -   close\n" +
				$"Tuesday   -   open\n" +
				$"Wednesday -   open\n" +
				$"Thursday  -   open\n" +
				$"Friday    -   open\n" +
				$"Saturday  -   close\n" +
				$"Sunday    -   close\n");
			Console.WriteLine($"Timetable second office:\n" +
				$"Monday    -   close\n" +
				$"Tuesday   -   close\n" +
				$"Wednesday -   close\n" +
				$"Thursday  -   open\n" +
				$"Friday    -   open\n" +
				$"Saturday  -   open\n" +
				$"Sunday    -   open\n");
			do
			{
				Console.WriteLine($"Input like date (dd.mm.yy)");

				if (!DateTime.TryParse(Console.ReadLine(), out dd))
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Invalid date format!!! \n Try again.");
					Console.ResetColor();
				}
				else
				{
					break;
				}
			}
			while (true);

			switch (dd.DayOfWeek)
			{
				case DayOfWeek.Monday:
					isOpenOffice1 = Days.Monday == (Days.Monday & OpenOffice1);
					isOpenOffice2 = Days.Monday == (Days.Monday & OpenOffice2);
					break;
				case DayOfWeek.Tuesday:
					isOpenOffice1 = Days.Tuesday == (Days.Tuesday & OpenOffice1);
					isOpenOffice2 = Days.Tuesday == (Days.Tuesday & OpenOffice2);
					break;
				case DayOfWeek.Wednesday:
					isOpenOffice1 = Days.Wednesday == (Days.Wednesday & OpenOffice1);
					isOpenOffice2 = Days.Wednesday == (Days.Wednesday & OpenOffice2);
					break;
				case DayOfWeek.Thursday:
					isOpenOffice1 = Days.Thursday == (Days.Thursday & OpenOffice1);
					isOpenOffice2 = Days.Thursday == (Days.Thursday & OpenOffice2);
					break;
				case DayOfWeek.Friday:
					isOpenOffice1 = Days.Friday == (Days.Friday & OpenOffice1);
					isOpenOffice2 = Days.Friday == (Days.Friday & OpenOffice2);
					break;
				case DayOfWeek.Saturday:
					isOpenOffice1 = Days.Saturday == (Days.Saturday & OpenOffice1);
					isOpenOffice2 = Days.Saturday == (Days.Saturday & OpenOffice2);
					break;
				case DayOfWeek.Sunday:
					isOpenOffice1 = Days.Sunday == (Days.Sunday & OpenOffice1);
					isOpenOffice2 = Days.Sunday == (Days.Sunday & OpenOffice2);
					break;
			}

			Console.WriteLine($"---------------------------");
			Console.WriteLine($"{dd:d} - is {dd.DayOfWeek}.");
			Console.WriteLine($"---------------------------");

			if (isOpenOffice1)
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("First office is open");
				Console.ResetColor();

			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("First office is close");
				Console.ResetColor();
			}

			if (isOpenOffice2)
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine("Second office is open");
				Console.ResetColor();
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Second office is close");
				Console.ResetColor();
			}
			Console.ReadKey();
		}
	}
}
