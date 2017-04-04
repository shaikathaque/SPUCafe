using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
	[Activity(Label = "SPU Cafe", MainLauncher = true)]
	public class MainView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.main);
		}
	}
}
