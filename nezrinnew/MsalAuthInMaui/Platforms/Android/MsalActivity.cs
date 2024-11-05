
using Android.App;
using Android.Content;
using Microsoft.Identity.Client;

namespace MsalAuthInMaui.Platforms.Android
{
	[Activity(Exported = true)]
	[IntentFilter(new[] { Intent.ActionView },
		Categories = new[] { Intent.CategoryBrowsable, Intent.CategoryDefault },
		DataHost = "auth",
		DataScheme = "msalb4caaf3a-be01-4e06-8e33-e91c663e6061")]
	public class MsalActivity : BrowserTabActivity
	{
	}
}