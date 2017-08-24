using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using SPUCafe.Core;
using System.Diagnostics;

namespace SPUCafe.Droid
{
	[Activity(Label = "SPU Cafe", MainLauncher = true, Theme = "@android:style/Theme.Material.Light.NoActionBar")]
	public class MainView : MvxActivity<MainViewModel>
	{
		protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			System.Diagnostics.Debug.WriteLine("Main Activity OnCreate Called");

			string strFromScraper = await ScraperService.getDocAsync();
			System.Diagnostics.Debug.WriteLine("Inside MainView.cs, This is the string returned by getDocAsync:" + strFromScraper);

			ViewModel.LoadData();

			SetContentView(Resource.Layout.main);
		}
	}
}
