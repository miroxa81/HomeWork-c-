using System;
using System.IO;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string FileName = "startup.txt";

			File.WriteAllText(FileName, getData());
			File.AppendAllText(FileName, Environment.NewLine);
		}

		static string getData()
		{
			return Console.ReadLine();
		}

	}
}
