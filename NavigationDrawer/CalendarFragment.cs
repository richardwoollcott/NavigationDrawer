
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Helpers;

namespace NavigationDrawer
{
	public class CalendarFragment : Fragment
	{
		private readonly List<Binding> bindings = new List<Binding> ();
		private View view;

		private CalendarViewModel Vm
		{
			get
			{
				return App.Locator.Calendar;
			}
		}

		private TextView titleTextView;
		public TextView TitleTextView
		{
			get
			{
				return titleTextView ??
				  (titleTextView = view.FindViewById<TextView> (
				   Resource.Id.calendarTitleTextView));
			}
		}

		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

		public override void OnDestroy ()
		{
			base.OnDestroy ();

			foreach (Binding binding in bindings)
			{
				binding.Detach ();
			}

			bindings.Clear ();

			titleTextView = null;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			view = inflater.Inflate (Resource.Layout.CalendarView, container, false);

			return view;
		}

		public override void OnViewCreated (View view, Bundle savedInstanceState)
		{
			base.OnViewCreated (view, savedInstanceState);

			bindings.Add (this.SetBinding (
				() => Vm.Title,
				() => TitleTextView.Text,
				BindingMode.OneWay));
		}
	}
}

