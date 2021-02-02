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
		}
		public Notepad(string title, bool status, DateTime currentDate)
		{
			Title = title;
			Status = status;
			CurrentDate = currentDate;
		}

		public void ChangeStatus(bool status, DateTime currentDate)
		{
			if (status == true)
			{
				status = false;
			}
			else
			{
				status = true;
			}
		}
		public void ChangeDate(DateTime currentDate)
		{ 
			CurrentDate = currentDate; 
		}

		public void SetTitle(string title)
		{
			Title = title;
		}
	}
}
