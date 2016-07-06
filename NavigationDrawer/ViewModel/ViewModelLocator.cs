/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:NavigationDrawer"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace NavigationDrawer.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainViewModel>();
			SimpleIoc.Default.Register<MailViewModel> ();
			SimpleIoc.Default.Register<CalendarViewModel> ();
			SimpleIoc.Default.Register<ContactsViewModel> ();
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        
		public MailViewModel Mail
		{
			get
			{
				return ServiceLocator.Current.GetInstance<MailViewModel> ();
			}
		}

		public CalendarViewModel Calendar
		{
			get
			{
				return ServiceLocator.Current.GetInstance<CalendarViewModel> ();
			}
		}

		public ContactsViewModel Contacts
		{
			get
			{
				return ServiceLocator.Current.GetInstance<ContactsViewModel> ();
			}
		}

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}