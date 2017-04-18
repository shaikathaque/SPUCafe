using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
[Activity(Label = "Meals", Theme = "@android:style/Theme.Material.Light.NoActionBar")]
	public class MealsView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.meals_view);
		}
	}
}