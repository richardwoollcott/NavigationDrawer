using System;
using GalaSoft.MvvmLight;

namespace NavigationDrawer
{
	public class MailViewModel : ViewModelBase
	{
		public MailViewModel ()
		{
			Title = "Mail";
		}

		private string title;

		public string Title
		{
			get { return title; }

			set { Set (ref title, value); }
		}
	}
}

