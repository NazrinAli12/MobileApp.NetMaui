using nezrinnew.Pages;

namespace nezrinnew;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navigationPage = new NavigationPage(new StackLayoutDemo());
		MainPage = navigationPage;
	}
}
