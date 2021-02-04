using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteLineColor("Hello. It's small notepad.", ConsoleColor.Yellow);

			Notepad[] Tasks = new Notepad[Init().Length];

			do
			{
				int select = Menu();

				switch (select)
				{
					case 0:
						{
							return;
						}

					case 1:
						{
							Tasks = Init();
							View(Tasks);
							break;
						}
					case 2:
						{
							Notepad newTask = AddNewTask();
							UpLoadOneTask(newTask);
							Tasks = Init();
							UpLoadAllTask(Tasks);

							break;
						}
					case 3:
						{

							break;
						}
					case 4:
						{
							Tasks = Init();
							bool isRepaet;
							WriteLineColor("Please input number of completed task", ConsoleColor.DarkYellow);
							do
							{
								if (!int.TryParse(Console.ReadLine(), out int i))
								{
									WriteLineColor("Please input number of completed task", ConsoleColor.DarkYellow);
									isRepaet = true;
								}
								else
								{
									Tasks[i].Status = Tasks[i].ChangeStatus(Tasks[i].Status); ;
									isRepaet = false; 
								}
							} while (isRepaet);

							UpLoadAllTask(Tasks);
							
							break; }



				}


			} while (true);

		}


		static Notepad AddNewTask()
		{
			ConsoleKeyInfo kp;
			bool isRepeat = default;
			Notepad newTask = new Notepad();

			WriteLineColor("Please input task title", ConsoleColor.DarkYellow);
			newTask.Title = Console.ReadLine();
			do
			{
				WriteLineColor("Please input task date", ConsoleColor.DarkYellow);
				WriteColor("Enter the desired date:", ConsoleColor.DarkYellow);
				if (DateTime.TryParse(Console.ReadLine(), out DateTime CurDate))
				{
					newTask.CurrentDate = CurDate;
					isRepeat = false;
				}
				else
				{
					WriteColor("You entred wrong date!!!", ConsoleColor.Red);
					isRepeat = true;
				}
			}
			while (isRepeat);

			return newTask;
		}

		static void View(Notepad[] Tasks)
		{
			WriteColor($"#  ", ConsoleColor.White);
			WriteColor("Status", ConsoleColor.White);
			WriteColor("    Date    ", ConsoleColor.White);
			WriteLineColor("Title", ConsoleColor.White);
			WriteLineColor("-------------------------", ConsoleColor.White);

			for (int i = 0; i < Tasks.Length; i++)
			{
				if (Tasks[i].Status == true)
				{
					WriteColor($"{i + 1}. ", ConsoleColor.Gray);
					WriteColor(" [", ConsoleColor.DarkYellow);
					WriteColor("v", ConsoleColor.DarkGreen);
					WriteColor("]   ", ConsoleColor.DarkYellow);
					WriteColor($"{Tasks[i].CurrentDate.ToString("d")} ", ConsoleColor.White);
					WriteLineColor($"{Tasks[i].Title}", ConsoleColor.Gray);
				}
				else
				{
					WriteColor($"{i + 1}. ", ConsoleColor.Gray);
					WriteColor(" [", ConsoleColor.DarkYellow);
					WriteColor("x", ConsoleColor.DarkRed);
					WriteColor("]   ", ConsoleColor.DarkYellow);
					WriteColor($"{Tasks[i].CurrentDate.ToString("d")} ", ConsoleColor.White);
					WriteLineColor($"{Tasks[i].Title}", ConsoleColor.Gray);
				}
			}
		}
		static Notepad[] Init()
		{
			var options = new JsonSerializerOptions
			{
				ReadCommentHandling = JsonCommentHandling.Skip,
				AllowTrailingCommas = true,
			};

			Notepad[] ToDo = JsonSerializer.Deserialize<Notepad[]>($"{File.ReadAllText("ToDo.json")}", options);
			return ToDo;
		}

		static void UpLoadOneTask(Notepad Task)
		{
			string json = JsonSerializer.Serialize(Task);
			File.AppendAllText("ToDo.json", json+",");
		}
		static void UpLoadAllTask(Notepad [] Tasks)
		{
			string json = JsonSerializer.Serialize(Tasks);
			File.WriteAllText("ToDo.json", json);		
		}

		static int Menu()
		{
			int select;

			WriteColor($"\n" +
			$"========= MENU ==========\n" +
			$"View notepad	- press 1\n" +
			$"Add record	- press 2\n" +
			$"Delete record	- press 3\n" +
			$"Change status	- press 4\n" +
			$"Exit notepad	- press 0\n" +
			$"=========================\n", ConsoleColor.DarkGreen);

			WriteColor($"Please select:", ConsoleColor.DarkYellow);
			Console.ResetColor();

			while (!int.TryParse(Console.ReadLine(), out select) || select < 0 || select > 4)
			{
				WriteLineColor("Please select number from menu", ConsoleColor.Red);
			}
			Console.WriteLine();
			return select;
		}

		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}

		static void WriteLineColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(txt);
			Console.ResetColor();
		}
	}
}


