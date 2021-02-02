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
	

		List<Notepad> list = new List<Notepad>();
			Notepad Task = new Notepad();
			
/*
			for (int i = 0; i < 2; i++)
			{
				Task.SetTitle(Console.ReadLine());
				Task.ChangeDate(DateTime.Now);
				Task.ChangeStatus(true, DateTime.Now);
				list.Add(Task);
			}

				string json = JsonSerializer.Serialize(list);
				File.AppendAllText("todo.json", json);
	
*/

					string json = File.ReadAllText("todo.json");


					 list = JsonSerializer.Deserialize<Notepad>(json);


					Console.WriteLine(lst);	

		}


		static void Init()
		{
		}

		static void Menu()
		{
			ConsoleKeyInfo kp;
			bool isRepeat;
			do
			{
				{
					kp = Console.ReadKey();
					if (kp.KeyChar == Convert.ToChar("y") || kp.KeyChar == Convert.ToChar("Y"))
					{
						isRepeat = true;
					}
					else
					{
						return;
					}
				}
			} while (isRepeat);
		}

		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}


}
