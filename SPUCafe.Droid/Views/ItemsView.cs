using System;
using Android.App;
using MvvmCross.Droid.Views;

namespace SPUCafe.Droid
{
	[Activity(Label = "Entrees", Theme = "@android:style/Theme.Material.Light.NoActionBar")]
	public class ItemsView : MvxActivity
	{
		protected override void OnCreate(Android.OS.Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.items_view);
		}
	}
}
