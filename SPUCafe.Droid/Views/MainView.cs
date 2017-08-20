using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using SPUCafe.Core;
using System.Diagnostics;

namespace SPUCafe.Droid
{
	[Activity(Label = "SPU Cafe", MainLauncher = true, Theme = "@android:style/Theme.Material.Light.NoActionBar")]
	public class MainView : MvxActivity
	{
		protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			ScraperService scraper = new ScraperService();
			string strFromScraper = await scraper.getDocAsync();
			System.Diagnostics.Debug.WriteLine("Inside Main Activity. This is the string returned by getDocAsync:" + strFromScraper);

			SetContentView(Resource.Layout.main);
		}
	}
}
