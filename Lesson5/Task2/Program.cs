using System;
using System.IO;
using System.Text.Json;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			string Patch = "";
			string FileName = "startup.txt";

			if (isFileExist($"{Patch}{FileName}"))
			{
				File.AppendAllText(FileName, $"Файл изменён: {addDateTime()}");
				File.AppendAllText(FileName, Environment.NewLine);
				File.AppendAllText(FileName, getData());
				File.AppendAllText(FileName, Environment.NewLine);
			}
			else
			{
				File.WriteAllText(FileName, $"Файл создан: {addDateTime()}");
				File.AppendAllText(FileName, Environment.NewLine);
				File.AppendAllText(FileName, getData());
				File.AppendAllText(FileName, Environment.NewLine);
			}
		}


		static bool isFileExist(string FileName)
		{
			return File.Exists(FileName) ? true : false;
		}

		static string addDateTime()
		{
			return DateTime.Now.ToString("f");
		}
		static string getData()
		{
			return Console.ReadLine();
		}
	}
}
