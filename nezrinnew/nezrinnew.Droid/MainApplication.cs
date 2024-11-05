using Android.App;
using Android.Runtime;
using Microsoft.Maui;

namespace nezrinnew.Droid
{
	[Application]
	public class MainApplication : MauiApplication
	{
		public MainApplication(nint handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}

		protected override MauiApp CreateMauiApp() => nezrinnew.MauiProgram.CreateMauiApp();
	}
}
