using DemoInfermieri.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace DemoInfermieri
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();
		    Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjk3NzdAMzEzNjJlMzMyZTMwQXRHYmpuSDdrK1U5bkhzN0E3UFpBaXc1d0JJUTR0SWRYOWdDZzF1OWMrUT0=");

            MainPage = new Registrazione();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
