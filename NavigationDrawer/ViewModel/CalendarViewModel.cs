using System;
using GalaSoft.MvvmLight;

namespace NavigationDrawer
{
	public class CalendarViewModel : ViewModelBase
	{
		public CalendarViewModel ()
		{
			Title = "Calendar";
		}

		private string title;

		public string Title
		{
			get { return title; }

			set { Set (ref title, value); }
		}
	}
}

