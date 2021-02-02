using System;

namespace Task5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Notepad[] ToDo = new Notepad();




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
