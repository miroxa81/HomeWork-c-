using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int count;
			string gFirstName, gLastName, gPatronymic;

			Console.WriteLine("Please input quantity users");
			count = ReadInt();
			string[] Data = new string[count];

			for (int i = 0; i < count; i++)
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine($"User #{i + 1}");
				Console.ResetColor();

				GetUserData(out gFirstName, out gLastName, out gPatronymic);

				Data[i] = GetFullName(gFirstName, gLastName, gPatronymic);
			}
			OutData(Data);
		}
		static void GetUserData(out string FirstName, out string LastName, out string Patronymic)
		{
			WriteDarkGreen("Input first name:");
			FirstName = Console.ReadLine();
			WriteDarkGreen("Input last name:");
			LastName = Console.ReadLine();
			WriteDarkGreen("Input patronymic:");
			Patronymic = Console.ReadLine();
		}

		static string GetFullName(string FirstName, string LastName, string Patronymic)
		{
			return ($"{FirstName} {LastName} {Patronymic}");
		}
		static void OutData(string[] Data)
		{
			Console.WriteLine("All users:");
			for (int i = 0; i < Data.GetLength(0); i++)
			{
				WriteDarkYellow($"User #{i + 1}.");
				WriteDarkGreen($" {Data[i]}");
				Console.WriteLine();
			}
			Console.ReadKey();
			return;
		}
		static void WriteDarkGreen(string txt)
		{
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.Write(txt);
			Console.ResetColor();

		}
		static void WriteDarkRed(string txt)
		{
			Console.ForegroundColor = ConsoleColor.DarkRed;
			Console.Write(txt);
			Console.ResetColor();

		}
		static void WriteDarkYellow(string txt)
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.Write(txt);
			Console.ResetColor();

		}
		static int ReadInt()
		{
			int number;
			while (!int.TryParse(Console.ReadLine(), out number))
			{
				WriteDarkRed("Please input numerical data");
				Console.WriteLine();
			}
			return number;
		}
	}
}
