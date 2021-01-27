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
			int count=0;


			Console.WriteLine("Hello. It's small notepad.");

			while (true)
			{


				Console.WriteLine($"\n" +
				$"========= MENU ==========\n" +
				$"View notepad	- press 1\n" +
				$"Add record	- press 2\n" +
				$"Delete record	- press 3\n" +
				$"Change record	- press 4\n" +
				$"Exit notepad	- press 0\n" +
				$"=========================\n" +
				$"Please select:");

				while (int.TryParse(Console.ReadLine(), out select))
				{
					Console.WriteLine("Please select number from menu");
				}

				switch (select)
				{

					case 1:
						{
							if (count == 0)
							{
								Console.WriteLine("You don't have any records");
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
							}
							break;
						}
					case 2:
						{
							if (count > 5)
							{
								Console.WriteLine("Notepad is full. Please delete something.");
								break;
							}

							Console.WriteLine("Please enter name:");
							Name = Console.ReadLine();
							Console.WriteLine("Please enter phone number:");                            //String.Format("{0:+# (###) ###-##-##}", number);
							PhoneNum = Console.ReadLine();
							Console.WriteLine("Please enter e-mail:");
							Mail = Console.ReadLine();
							Note[count, 0] = Name;
							Note[count, 1] = ($"{PhoneNum}/{Mail}");
							count++;
							break;


						}
					case 3:
						{

							Console.WriteLine("Please enter the name to be deleted:");

							Name = Console.ReadLine();
							if (count != 0)
							{
								for (int i = 0; i < count; i++)
								{
									if (Note[i, 0] == Name)
									{
										if (i == Note.GetLength(0))
										{
											Note[i, 0] = "";
											Note[i, 1] = "";
										}
										else
										{
											for (j = i; j < count; j++)
											{
												Note[j, 0] = Note[j + 1, 0];
												Note[j, 1] = Note[j + 1, 1];

											}
											break;
										}
									}
								}
								Console.WriteLine("Name not found!");
								break;
							}
							else
							{
								Console.WriteLine("Notepad is empty. Nothing to delete.");
								break;
							}
						}
					case 4:
						{
							Console.WriteLine("Please enter the name to be changed:");
							Name = Console.ReadLine();
							if (count != 0)
							{
								for (int i = 0; i < count; i++)
								{
									if (Note[i, 0] == Name)
									{
										Console.WriteLine("Please enter new name:");
										Name = Console.ReadLine();
										Console.WriteLine("Please enter new phone number:");                            //String.Format("{0:+# (###) ###-##-##}", number);
										PhoneNum = Console.ReadLine();
										Console.WriteLine("Please enter new e-mail:");
										Mail = Console.ReadLine();
										Note[i, 0] = Name;
										Note[i, 1] = ($"{PhoneNum}/{Mail}");
										break;
									}
								}
								Console.WriteLine("Name not found!");
								break;
							}
							else
							{
								Console.WriteLine("Notepad is empty. Nothing to change.");
								break;
							}
						}
					case 0:
						{
							Console.WriteLine("Goodbay. Press any key to end programm.");
							Console.ReadKey();
							return;
						}
					default:
						Console.WriteLine("DEFAULT");
						break;

				}


			}


		}
	}

}