using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
	[Activity(Label = "Days", Theme = "@android:style/Theme.Material.Light.NoActionBar")]
	public class DaysView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.days_view);
		}
	}
}

