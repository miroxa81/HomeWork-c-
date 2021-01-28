using System;
namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			Random Digits = new Random();
			int DiagonalSelection;
			int DiagonalOffset;
			int DiagSum=0;

			Console.WriteLine("Please enter your name:");
			string name = Console.ReadLine();

			Console.WriteLine($"Hello, {name}, please enter two dimensions of array:");


			Console.WriteLine("Width:");
			int ArrayWidth = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Height:");
			int ArrayHigth = Convert.ToInt32(Console.ReadLine());


			do
			{
				Console.WriteLine("Which diagonal to show? \n 1. Main diagonal. \n 2. Side diagonal");
				DiagonalSelection = Convert.ToInt32(Console.ReadLine());

				if (DiagonalSelection == 1 || DiagonalSelection == 2)
				{
					break;
				}
			} while (true);

			do
			{
				Console.WriteLine($"Which offset of diagonal ? From {ArrayWidth * (-1) + 1} to  {ArrayWidth - 1}");
				DiagonalOffset = Convert.ToInt32(Console.ReadLine());

				if (DiagonalOffset > ArrayWidth * (-1) && DiagonalOffset < ArrayWidth)
				{
					break;
				}
			} while (true);


			int[,] Array = new int[ArrayWidth, ArrayHigth];

			for (int i = 0; i < ArrayWidth; i++)
			{
				for (int j = 0; j < ArrayHigth; j++)
				{
					Array[i, j] = Digits.Next(0, 99);
				}
			}
			for (int i = 0; i < ArrayWidth; i++)
			{
				for (int j = 0; j < ArrayHigth; j++)
				{
					if (DiagonalSelection == 1)
					{

						if (i + DiagonalOffset == j)
						{
							Console.ForegroundColor = ConsoleColor.Green;
							if (Convert.ToString(Array[i, j]).Length == 1)
							{
								Console.Write($"{Array[i, j],1} ");
							}
							else
							{
								Console.Write($"{Array[i, j]} ");
							}

							if (j == ArrayHigth - 1)
							{
								Console.WriteLine("\n");
							}
							Console.ResetColor();
							DiagSum += Array[i, j];
							continue;
						}
					}
					if (DiagonalSelection == 2)
					{
						if (i + DiagonalOffset == ArrayHigth - j - 1)
						{
							Console.ForegroundColor = ConsoleColor.Green;
							if (Convert.ToString(Array[i, j]).Length == 1)
							{
								Console.Write($"{Array[i, j],-1} ");
							}
							else
							{
								Console.Write($"{Array[i, j]} ");
							}
							if (j == ArrayHigth - 1)
							{
								Console.WriteLine("\n");
							}
							Console.ResetColor();
							DiagSum += Array[i, j];
							continue;
						}
					}
					if (Convert.ToString(Array[i, j]).Length == 1)
					{
						Console.Write($" {Array[i, j]} ");
					}
					else
					{
						Console.Write($"{Array[i, j]} ");
					}

					if (j == ArrayHigth - 1)
					{
						Console.WriteLine("\n");
					}
				}
			}
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine($"The sum of the numbers of the selected diagonal: {DiagSum}.");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine($"Press any key to end program.");
			Console.ResetColor();

			Console.ReadKey();
		}
	}
}
