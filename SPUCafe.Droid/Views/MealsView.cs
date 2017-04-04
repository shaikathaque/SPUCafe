using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
	[Activity(Label = "Meals")]
	public class MealsView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.meals_view);
		}
	}
}