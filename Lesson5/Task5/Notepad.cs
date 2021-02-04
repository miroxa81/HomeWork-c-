using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
	public class Notepad
	{
		public string Title { get; set; }
		public bool Status { get; set; } = false;
				
		public DateTime CurrentDate { get; set; }

		public Notepad()
		{
			Title = "";
			Status = false;
			CurrentDate = DateTime.Now;

		}
		public Notepad(string title, bool status, DateTime currentDate)
		{
			Title = title;
			Status = status;
			CurrentDate = currentDate;
		}

		public bool ChangeStatus(bool status)
		{
			if (status == true)
			{
				return  false;
			}
			else
			{
				return  true;
			}
		}

	}
}
