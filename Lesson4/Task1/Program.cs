using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please input your first name");
			string Patronymic =  Convert.ToString(Console.ReadLine());
			Console.WriteLine("Please input your last name");
			string LastName = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Please input your patronymic");
			string Patronymic = Convert.ToString(Console.ReadLine());

			GetFullName(FirstName, LastName, Patronymic);
		}
			

		static string GetFullName(string firstName, string lastName, string patronymic)
		{
			string FullName = ($"{}{}{}");
			
		}
	}
}
