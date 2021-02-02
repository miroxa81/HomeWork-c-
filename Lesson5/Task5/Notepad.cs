using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
	public class Notepad
	{
		public string Title { get; set; }
		public bool Status { get; set; }
		public DateTime ChangeDate { get; set; }


		public Notepad(string title, bool status, DateTime changedate)
		{

			Title = title;
			Status = status;
			ChangeDate = changedate;		
		}


	}
}
