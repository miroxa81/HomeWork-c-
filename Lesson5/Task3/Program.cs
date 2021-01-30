using System;
using System.IO;

namespace Task3
{
	class Program
	{
		static void Main(string[] args)
		{
			//string Line;
			//bool isOk;
			//int lenght;

			WriteColor($"Введите набор цифр от 0 до 255:", ConsoleColor.Gray);
			
			byte[] Array = getData();

			
			File.WriteAllBytes($"byte.bin", getData());
			
		}






		static byte[]  getData()
		{			
			string [] InputLine = Console.ReadLine().Split(new char[] { ' ' });
			byte[] Array = new byte[InputLine.Length];
			string unit;
			for (int i = 0; i < InputLine.Length; i++)
			{
				unit = InputLine[i];
				if (byte.TryParse(unit, out byte N))
				{
					Array[i] = N;
				}
				else
				{
					WriteColor("Вы ввели информцию не удовлетворяющую условию", ConsoleColor.Red);
					break;
				}
			}
			return Array;
			}
	


		static void WriteColor(string txt, ConsoleColor color)
		{
			Console.ForegroundColor = color;
			Console.Write(txt);
			Console.ResetColor();
		}

		static bool isDigit()
		{
			while (true)
				{
				
				ConsoleKeyInfo keyPress = Console.ReadKey(true);
			char input = keyPress.KeyChar;

				if (char.IsLetter(input))
				{
					WriteColor("Можно вводить только цифры! Начните ввод сначала!", ConsoleColor.Red);

					break;
				}

				if (char.IsDigit(input))
				{
					//string[] Line = Line + input;
				}		

			}
			return false;
		}
	}
}
