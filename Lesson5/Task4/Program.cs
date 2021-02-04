using System;
using System.IO;

namespace Task4
{
	class Program
	{
		static string FullFilePatch;
		static void Main(string[] args)
		{
			string SD;
			string FileName = "Catalogue.txt";

			ConsoleKeyInfo kp;
			bool isRepeat;
			do
			{
				isRepeat = false;
				SD = GetStartDir();
				if (SD == "wrong directory")
				{
					WriteColor("Такого каталога не существует!!!", ConsoleColor.Red);
					Console.WriteLine();
					WriteColor("Если хотите повторить ввод, нажмите ", ConsoleColor.Gray);
					WriteColor("'y'", ConsoleColor.Yellow);
					WriteColor(".", ConsoleColor.Gray);
					Console.WriteLine();
					WriteColor("Для выхода нажмите любую клавишу.", ConsoleColor.Gray);
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

			DirectoryInfo StartDir = new DirectoryInfo(SD);
			FullFilePatch = Path.Combine(StartDir.FullName, FileName);
			if (File.Exists(FullFilePatch)) File.Delete(FullFilePatch);
			File.AppendAllText(FullFilePatch, $"Файл создан: {DateTime.Now.ToString("f")}");
			File.AppendAllText(FullFilePatch, Environment.NewLine);
			GetDirInfo(StartDir);
			WriteColor($"Результат сохранён в {FullFilePatch}", ConsoleColor.Yellow);
		}
		static string GetStartDir()
		{
			string ExDir;
			WriteColor("Введите пусть к каталогу который нужно отсканировать. Пример:", ConsoleColor.Gray);
			WriteColor("'C:\\Temp'", ConsoleColor.Yellow);
			Console.WriteLine();
			ExDir = Console.ReadLine();
			if (Directory.Exists(ExDir))
			{
				return ExDir;
			}
			else
			{
				ExDir = "wrong directory";
				return ExDir;
			}
		}
		static void GetDirInfo(DirectoryInfo StartDir)
		{
			FileInfo[] FilesInDir = null;
			DirectoryInfo[] SubDirs = null;

			FilesInDir = StartDir.GetFiles("*.*");

			if (FilesInDir != null)
			{
				for (int i = 0; i < FilesInDir.Length; i++)
				{


					File.AppendAllText(FullFilePatch, FilesInDir[i].Name);
					File.AppendAllText(FullFilePatch, Environment.NewLine);
					//					if (FilesInDir[i].Name == "Catalogue.txt")
					//					{
					//						File.Delete(FilesInDir[i].FullName);
					//					}
				}

				SubDirs = StartDir.GetDirectories();

				for (int i = 0; i < SubDirs.Length; i++)
				{
					File.AppendAllText(FullFilePatch, Environment.NewLine);
					File.AppendAllText(FullFilePatch, "Каталог:");
					File.AppendAllText(FullFilePatch, Environment.NewLine);
					File.AppendAllText(FullFilePatch, SubDirs[i].FullName);
					File.AppendAllText(FullFilePatch, Environment.NewLine);
					File.AppendAllText(FullFilePatch, "Файлы:");
					File.AppendAllText(FullFilePatch, Environment.NewLine);
					GetDirInfo(SubDirs[i]);
				}
			}
		}
		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}
	}
}

