using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
	[Activity(Label = "Days")]
	public class DaysView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.days_view);
		}
	}
}

