using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int count;
			Console.WriteLine("Please input quantity users");
			
			count = ReadInt();
			string[] Data = new string[count];

			for (int i = 0; i < count; i++)
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine($"User #{i + 1}");
				Console.ResetColor();
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine($"Input first name");
				Console.ResetColor();
				string FirstName = Convert.ToString(Console.ReadLine());
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine($"Input last name");
				Console.ResetColor();
				string LastName = Convert.ToString(Console.ReadLine());
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine($"Input patronymic");
				Console.ResetColor();
				string Patronymic = Convert.ToString(Console.ReadLine());

				Data[i] = GetFullName(FirstName, LastName, Patronymic);
			}

/*			for (int i = 0; i < count; i++)
			{
				Console.WriteLine($"User #{i + 1}. {Data[i]}");
			}
			Console.ReadKey();
*/
			OutData(Data);
		}


		static int ReadInt()
		{
			int number;
			while (!int.TryParse(Console.ReadLine(), out number))
			{
				Console.ForegroundColor = ConsoleColor.DarkRed;
				Console.WriteLine("Please input numerical data");
				Console.ResetColor();
			}
			return number;

		}


		static string GetFullName(string FirstName, string LastName, string Patronymic)
		{
			string FullName = ($"{FirstName} {LastName} {Patronymic}");
			return FullName;
		}


		static void OutData(string[] Data)
				{
					for (int i = 0; i<Data.GetLength(0); i++)
						{
						Console.WriteLine($"User #{i+1}. {Data[i]}");
						}
						Console.ReadKey();
					return;
				}
		
	}
}
