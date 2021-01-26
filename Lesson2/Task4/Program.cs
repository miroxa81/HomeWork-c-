using System;


namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			String Company = "ООО ПРИМЕР";
			String Title = "Добро пожаловать";
			String KKM = "00075411";
			String INN = "1087746942040";
			String EKLZ = "3851495566";
			DateTime DateTimeNow = DateTime.Now;
			string[] Names = { "Мороженое", "Шоколад", "Варенье", "Печенье" };
			int[] qty = { 2, 3, 5, 1 };
			float[] Price = { 10.22F, 20.11F, 30.43F, 40.28F };
			float sum = 0;

			Console.WriteLine($"" +
				$"{"",10}{Company,0}\n" +
				$"{"",0}{Title,25}\n" +
				$"{"",0}{"ККМ",-10}{KKM,25}\n" +
				$"{"",0}{"ИНН",-10}{INN,25}\n" +
				$"{"",0}{"ЭКЛЗ",-10}{EKLZ,25}\n" +
				$"{"",0}{"Кассир №1",-10}{DateTimeNow,25}\n" +
				$"-----------------------------------");

			for (int i = 0; i < Names.Length; i++)
			{
				Console.WriteLine("{0,-20} {1,5:N1}", Names[i], qty[i] + " x " + Price[i] + " грн");
				Console.WriteLine("{0,-20}", qty[i] * Price[i] + " грн");
				sum += qty[i] * Price[i];

			}


			Console.WriteLine($"-----------------------------------\n" +
			$"ИТОГ{sum,26} грн\n" +
			$"НАЛИЧНЫМИ {sum,20} грн\n" +
			$"-----------------------------------\n" +
			$"{"ЧЕК 00003751# 059705",25}\n" +
			$"");

			Console.ReadKey();
		}
	}
}
