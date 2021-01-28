using System;

namespace Task4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] SeaDesc = new int[10, 10];


			CreateCleanSeaDesc(SeaDesc);

			ShipsCreate(SeaDesc);

			ShowSeaDesc(SeaDesc);
		}



		static void ShowSeaDesc(int[,] SeaDesc)
		{
			string[] xHead = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "G" };
			string[] yHead = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

			Console.Write($" #|");

			for (int head = 0; head < 10; head++)
			{
				Console.Write($"{xHead[head]}|");
			}
			Console.WriteLine();
			for (int k = 0; k < 10; k++)
			{
				Console.Write($"--");
			}
			Console.WriteLine();



			for (int i = 0; i < 10; i++)
			{
				Console.Write($"{yHead[i],2}|");
				

				for (int j = 0; j < 10; j++)
				{
					if (SeaDesc[i, j] == -1) { Console.Write($"o|"); }
					if (SeaDesc[i, j] == 0) {
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.Write($"X|");
						Console.ResetColor();
					}
				}
				Console.WriteLine();

				for (int k = 0; k < 10; k++)
				{
					Console.Write($"--");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}


		static void CreateCleanSeaDesc(int[,] SeaDesc)
		{
			for (int i = 0; i < 10; i++)
				for (int j = 0; j < 10; j++)
				{
					SeaDesc[i, j] = -1;
				}
		}

		static void ShipsCreate(int[,] SeaDesc)
		{
			Random rnd = new Random();
			int xStart = 0, yStart = 0;
			int DeckShip, QtyShip, Deck;
			bool BuildShip;
			int xOrient = 0, yOrient = 0;




			for (DeckShip = 3; DeckShip >= 0; DeckShip--)
			{
				for (QtyShip = 0; QtyShip <= 3 - DeckShip; QtyShip++)
				{
					do
					{

						xStart = rnd.Next(1, 10);
						yStart = rnd.Next(1, 10);
						int Orient = rnd.Next(0, 3);

						if (Orient == 0 || Orient == 2) { xOrient = 1; yOrient = 0; }
						else
						if (Orient == 1 || Orient == 3) { xOrient = 0; yOrient = 1; };

						BuildShip = true;

						for (Deck = 0; Deck <= DeckShip; Deck++)
						{
							if (!FreePoint(xStart + xOrient * Deck, yStart + yOrient * Deck, SeaDesc))
							{
								BuildShip = false;
							}
						}

						if (BuildShip)
						{
							for (Deck = 0; Deck <= DeckShip; Deck++)
							{
								SeaDesc[xStart + xOrient * Deck, yStart + yOrient * Deck] = 0;
							}
						}

					} while (!BuildShip);
				}
			}
		}


		static bool FreePoint(int xStart, int yStart, int[,] SeaDesc)
		{
			int[,] Nearby = { { 1, 1 }, { 0, 1 }, { -1, 1 }, { 1, -1 }, { 0, -1 }, { -1, -1 }, { 1, 0 }, { -1, 0 } };
			int xNearby, yNearby;

			if (xStart > 0 && xStart < 10 && yStart > 0 && yStart < 10 && SeaDesc[xStart, yStart] == -1)
			{
				int count = 0;
				for (int i = 0; i < 8; i++)
				{
					xNearby = xStart + Nearby[i, 0];
					yNearby = yStart + Nearby[i, 1];

					if (xNearby > 0 && xNearby < 10 & yNearby > 0 && yNearby < 10 && SeaDesc[xNearby, yNearby] > -1)
					{
						count++;
					}
				}
				return count == 0 ? true : false;
			}
			else
			{
				 return false;
			}

			
		}
	}
}

