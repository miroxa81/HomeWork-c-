using System;
using System.Diagnostics;
using System.IO;


namespace Task1
{
	class Program
	{

		static string FileCreate(string Head, string Sep, string Patch, string FileName)
		{
			File.WriteAllText(FileName, $"Файл создан: {DateTime.Now.ToString("f")}");
			File.AppendAllText(FileName, Environment.NewLine);
			File.AppendAllText(FileName, Sep);
			File.AppendAllText(FileName, Environment.NewLine);
			File.AppendAllText(FileName, Head);
			File.AppendAllText(FileName, Environment.NewLine);
			File.AppendAllText(FileName, Sep);
			File.AppendAllText(FileName, Environment.NewLine);
			return Path.Combine(Patch + FileName);
		}

		static void Main(string[] args)
		{
			string Patch = "";
			string FileName = "log.txt";
			string Head = $"{"#",-10}{"Id процесса",-20}{"Имя процесса"}";
			string Sep = $"{"-------------------------------------------------------------"}";


			Process[] TaskList = Process.GetProcesses();
			string[] TaskListName = new string[TaskList.Length];
			int[] TaskListId = new int[TaskList.Length];
			for (int i = 1; i < TaskList.Length; i++)
			{
				TaskListName[i] = TaskList[i].ProcessName;
				TaskListId[i] = TaskList[i].Id;
			}
			Array.Sort(TaskListName, TaskListId);


			string FullFileName = FileCreate(Head, Sep, Patch, FileName);


			OutData(TaskList, TaskListId, TaskListName, Head, Sep, FullFileName);

			WriteColor("Веедите ИМЯ или ID процесса который нужно завершить:", ConsoleColor.DarkYellow);
			string UserQuery = Console.ReadLine(); Console.WriteLine();

			string[] ID = SearchID(UserQuery, TaskListId, TaskListName);

			Process[] KillList = new Process[ID.Length];

			if (KillList.Length == 0)
			{
				WriteLineColor($"Процесс не найден", ConsoleColor.DarkRed);
				WriteLineColor($"После нажатия любой клавиши, программа завершит свою работу.", ConsoleColor.Gray);
				Console.ReadKey();
			}
			else
			{
				ConsoleKeyInfo kp;

				WriteLineColor(Head, ConsoleColor.Yellow);
				WriteLineColor(Sep, ConsoleColor.Yellow);
				for (int i = 0; i < ID.Length; i++)
				{
					KillList[i] = Process.GetProcessById(Convert.ToInt32(ID[i]));
					WriteLineColor($"{i,-10}{KillList[i].Id,-20}{KillList[i].ProcessName}", ConsoleColor.DarkGray);
				}
				WriteLineColor(Sep, ConsoleColor.DarkRed);
				WriteLineColor("Остановить - нажмите 'Enter'.", ConsoleColor.Red);
				WriteLineColor("Завершить программу - 'любая клавиша'", ConsoleColor.Gray);

				kp = Console.ReadKey();
				if (kp.Key == ConsoleKey.Enter)
				{
						KillHim(KillList, FullFileName);
				}
			}
			WriteLineColor("До новых встреч!!!", ConsoleColor.DarkYellow);
			Console.ReadKey();
		}

		static void OutData(Process[] TaskList, int[] TaskListId, string[] TaskListName, string Head, string Sep, string FullFileName)
		{
			ConsoleKeyInfo kp;
			bool isEndPage = false;
			int page = 0; int pageSep = 22;
			int qtyPage = (int)TaskList.Length / pageSep + 1;

			WriteLineColor(Head, ConsoleColor.Yellow);
			WriteLineColor(Sep, ConsoleColor.Yellow);

			for (int i = 1; i < TaskList.Length; i++)
			{
				string Body = $"{i,-10}{TaskListId[i],-20}{TaskListName[i]}";

				WriteLineColor(Body, ConsoleColor.DarkGray);
				File.AppendAllText(FullFileName, Body);
				File.AppendAllText(FullFileName, Environment.NewLine);
				if (!isEndPage)
				{
					if (i % pageSep == 0)
					{
						page++;
						WriteLineColor(Sep, ConsoleColor.Yellow);
						Console.WriteLine($"Страница {page} из {qtyPage}. ");
						WriteLineColor("Следующая страница - 'любая клавиша'", ConsoleColor.Gray);
						WriteLineColor("Последняя страница - нажмите 'Enter'.", ConsoleColor.Gray);
						WriteLineColor(Sep, ConsoleColor.Yellow);
						kp = Console.ReadKey();
						if (kp.Key == ConsoleKey.Enter) { isEndPage = true; }
						Console.Clear();
						WriteLineColor(Head, ConsoleColor.Yellow);
						WriteLineColor(Sep, ConsoleColor.Yellow);
					}
				}
			}
			if (page == qtyPage - 1)
			{
				WriteLineColor(Sep, ConsoleColor.Yellow);
				Console.Write($"Страница {page + 1} из {qtyPage}. ");
				WriteLineColor($"Конец списка.", ConsoleColor.Gray);
				WriteLineColor(Sep, ConsoleColor.Yellow);
			}
			else
			{
				WriteLineColor(Sep, ConsoleColor.Yellow);
				Console.Write($"Всего в списке {qtyPage} страниц.");
				WriteLineColor($"Конец списка.", ConsoleColor.Gray);
				WriteLineColor(Sep, ConsoleColor.Yellow);

			}
		}

		static void KillHim(Process[] KillList, string FullFileName)
		{

			for (int i = 0; i < KillList.Length; i++)
			{
					string res = "";
					try
					{
					KillList[i].Kill();
						WriteColor($"Процесc ", ConsoleColor.Green);
						WriteColor($"{KillList[i].ProcessName} ", ConsoleColor.Yellow);
						WriteLineColor($"был остановлен.", ConsoleColor.Green);

						res = $"Процес (ID {KillList[i].Id}){KillList[i].ProcessName} был остановлен.\n";
					}
					catch (Exception e)
					{
						WriteColor($"Процесc ", ConsoleColor.Red);
						WriteColor($"{KillList[i].ProcessName} ", ConsoleColor.Yellow);
						WriteLineColor($"не был остановлен.{e.Message}", ConsoleColor.Red);
						res = $"Процес (ID {KillList[i].Id}){KillList[i].ProcessName} не был остановлен. Ошибка: {e.Message}\n";
					}
					finally
					{
						File.AppendAllText(FullFileName, res);
					}
				

			}
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
		static string[] SearchID(string Proc, int[] tasklistID, string[] tasklistName)
		{
			int Qty = 0;
			string[] Result = new string[Qty];
			if (int.TryParse(Proc, out int ProcID))
			{
				for (int i = 0; i < tasklistID.Length; i++)
				{
					if (ProcID == tasklistID[i])
					{
						Qty++;
						Array.Resize(ref Result, Qty);
						Result[Qty - 1] = Convert.ToString(tasklistID[i]);
					}
				}
			}
			else
			{
				for (int i = 0; i < tasklistID.Length; i++)
				{
					if (Proc == tasklistName[i])
					{
						Qty++;
						Array.Resize(ref Result, Qty);
						Result[Qty - 1] = Convert.ToString(tasklistID[i]);
					}
				}
			}
			return Result;
		}
	}
}


