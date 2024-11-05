// App.xaml.cs
using Microsoft.Maui.Controls;

namespace MsalAuthInMaui
{
	public partial class App : Application
	{
		public App(MainPage page)
		{
			InitializeComponent();
			MainPage = page;
		}
	}
}
