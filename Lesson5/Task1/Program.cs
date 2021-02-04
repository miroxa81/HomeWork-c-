using System;
using System.IO;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string FileName = "startup.txt";
			WriteColor("Введите строку символов:", ConsoleColor.DarkYellow);
			File.WriteAllText(FileName, getData());
			File.AppendAllText(FileName, Environment.NewLine);
			WriteColor($"Создан файл:{FileName}", ConsoleColor.Yellow);
		}

		static string getData()
		{
			return Console.ReadLine();
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
