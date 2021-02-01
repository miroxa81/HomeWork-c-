using System;
using System.IO;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteColor($"Введите через пробел набор цифр от 0 до 255:", ConsoleColor.Gray);
			if (CreateByteBin() && File.Exists("byte.bin"))
			{
				WriteColor($"Файл byte.bin успешно создан", ConsoleColor.Green);
			}
			else
			{
				WriteColor($"Вы ввели недопустимые данные. Файл byte.bin не созднан", ConsoleColor.Red);
			}
		}

		static bool CreateByteBin()
		{
			bool isOk=true;
			string unit;
			
			string [] InputLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			byte[] ArrayByte = new byte[InputLine.Length];
			
			for (int i = 0; i < InputLine.Length; i++)
			{
				unit = InputLine[i];
				if (byte.TryParse(unit, out byte N))
				{
					ArrayByte[i] = N;
				}
				else
				{
					isOk = false;
				}
			}
			if (isOk) 
			{
				File.WriteAllBytes($"byte.bin", ArrayByte);
				return true;
			}
			else
			{
				return false;
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
