using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Threading;
using GalaSoft.MvvmLight.Views;
using NavigationDrawer.ViewModel;

namespace NavigationDrawer
{
	public static class App
	{
		private static ViewModelLocator locator;

		public static ViewModelLocator Locator
		{
			get
			{
				if (locator == null)
				{
					DispatcherHelper.Initialize ();

					var nav = new NavigationService ();

					SimpleIoc.Default.Register<INavigationService> (() => nav);

					locator = new ViewModelLocator ();
				}

				return locator;
			}
		}
	}
}

