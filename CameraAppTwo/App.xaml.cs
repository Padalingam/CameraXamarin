using Xamarin.Forms;

namespace CameraAppTwo
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new CameraAppTwoPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
