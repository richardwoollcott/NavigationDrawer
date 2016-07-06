using System;
using GalaSoft.MvvmLight;

namespace NavigationDrawer
{
	public class ContactsViewModel : ViewModelBase
	{
		public ContactsViewModel ()
		{
			Title = "Contacts";
		}

		private string title;

		public string Title
		{
			get { return title; }

			set { Set (ref title, value); }
		}
	}
}

