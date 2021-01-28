using System;


namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] Note = new string[5, 2];
			int select;
			string Name, PhoneNum, Mail;
			int count = 0;
			Console.WriteLine("Hello. It's small notepad.");
			while (true)
			{
				Console.ForegroundColor = ConsoleColor.DarkGreen;
				Console.WriteLine($"\n" +
				$"========= MENU ==========\n" +
				$"View notepad	- press 1\n" +
				$"Add record	- press 2\n" +
				$"Delete record	- press 3\n" +
				$"Change record	- press 4\n" +
				$"Exit notepad	- press 0\n" +
				$"=========================\n" +
				$"Please select:");
				Console.ResetColor();

				while (!int.TryParse(Console.ReadLine(), out select) || select < 0 || select > 4)
				{
					Console.ForegroundColor = ConsoleColor.DarkRed;
					Console.WriteLine("Please select number from menu");
					Console.ResetColor();
				}

				switch (select)
				{
					case 1: //вывод блокнта 
						{
							if (count == 0)
							{
								Console.ForegroundColor = ConsoleColor.DarkYellow;
								Console.WriteLine("You don't have any records. Press any key to continue.");
								Console.ReadKey();
								Console.Clear();
								Console.ResetColor();
							}
							else
							{
								Console.WriteLine($"{"Name",-20}{"Phone/e-mail"}");
								Console.WriteLine($"------------------------------------");
								for (int i = 0; i < count; i++)
								{
									Console.WriteLine($"{Note[i, 0],-20}{Note[i, 1]}");
								}
								Console.WriteLine($"------------------------------------");
								Console.WriteLine($"Press any key to continue.");
								Console.ReadKey();
								Console.Clear();

							}
							break;
						}
					case 2: //добавление 
						{
							if (count > 5)
							{
								Console.ForegroundColor = ConsoleColor.DarkYellow;
								Console.WriteLine("Notepad is full. Please delete something. Press any key to continue.");
								Console.ReadKey();
								Console.Clear();
								Console.ResetColor();
								break;
							}
							Console.WriteLine("Please enter name:");
							Name = Console.ReadLine();
							Console.WriteLine("Please enter phone number:");
							PhoneNum = Console.ReadLine();
							Console.WriteLine("Please enter e-mail:");
							Mail = Console.ReadLine();
							Note[count, 0] = Name;
							Note[count, 1] = ($"{PhoneNum}/{Mail}");
							count++;
							Console.ForegroundColor = ConsoleColor.DarkYellow;
							Console.WriteLine($"Record adding to notepad. Press any key to continue.");
							Console.ReadKey();
							Console.Clear();
							break;
						}
					case 3: //удаление 
						{
							if (count != 0)
							{

								Console.WriteLine("Please enter the name to be deleted:");
								for (int i = 0; i < count; i++)
								{
									Console.WriteLine($"{Note[i, 0]}");
								}

								Name = Console.ReadLine();
								for (int i = 0; i < count; i++)
								{
									if (Note[i, 0] == Name)
									{
										if (i == Note.GetLength(0) - 1)
										{
											Note[i, 0] = "";
											Note[i, 1] = "";
											count--;
											//	break;
										}
										else
										{
											for (int j = i; j < Note.GetLength(0) - 1; j++)
											{
												Note[j, 0] = Note[j + 1, 0];
												Note[j, 1] = Note[j + 1, 1];
											}
											count--;
										}
									}
									else
									{
										if (i == count - 1)
										{
											Console.ForegroundColor = ConsoleColor.DarkYellow;
											Console.WriteLine("Name not found! Press any key to continue.");
											Console.ReadKey();
											Console.Clear();
											Console.ResetColor();
										}

									}
								}
								break;
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.DarkYellow;
								Console.WriteLine("Notepad is empty. Nothing to delete. Press any key to continue.");
								Console.ReadKey();
								Console.Clear();
								Console.ResetColor();
								break;
							}
						}
					case 4: //изменение записи
						{
							if (count != 0)
							{
								Console.WriteLine("Please enter the name to be changed:");
								for (int i = 0; i < count; i++)
								{
									Console.WriteLine($"{Note[i, 0]}");
								}

								Name = Console.ReadLine();
								for (int i = 0; i < count; i++)
								{
									if (Note[i, 0] == Name)
									{
										Console.WriteLine("Please enter new name:");
										Name = Console.ReadLine();
										Console.WriteLine("Please enter new phone number:");
										PhoneNum = Console.ReadLine();
										Console.WriteLine("Please enter new e-mail:");
										Mail = Console.ReadLine();
										Note[i, 0] = Name;
										Note[i, 1] = ($"{PhoneNum}/{Mail}");
										Console.ForegroundColor = ConsoleColor.DarkYellow;
										Console.WriteLine($"Record changed in the notepad. Press any key to continue.");
										Console.ReadKey();
										Console.Clear();
										break;
									}
									else
									{
										if (i == count - 1)
										{
											Console.ForegroundColor = ConsoleColor.DarkYellow;
											Console.WriteLine("Name not found! Press any key to continue.");
											Console.ReadKey();
											Console.Clear();
											Console.ResetColor();
										}
									}
								}
								break;
							}
							else
							{
								Console.ForegroundColor = ConsoleColor.DarkYellow;
								Console.WriteLine("Notepad is empty. Nothing to change. Press any key to continue.");
								Console.ReadKey();
								Console.Clear();
								Console.ResetColor();
								break;
							}
						}
					case 0: //выход из программы
						{
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("Goodbay. Press any key to end programm.");
							Console.ResetColor();
							Console.ReadKey();
							return;
						}
				}
			}
		}
	}
}