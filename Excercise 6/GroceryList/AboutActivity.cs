using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace GroceryList
{
	[Activity(Label = "About")]			
	public class AboutActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.About);

			FindViewById<Button>(Resource.Id.learnMoreButton).Click += OnLearnMoreClick;
		}

		void OnLearnMoreClick(object sender, EventArgs e)
		{
            // Use below if you wanna be more explicit
            // var intent = new Intent();
            // intent.SetAction(Intent.ActionView);

            // Gotta love them shortcuts
            var intent = new Intent(Intent.ActionView);
            intent.SetData(Android.Net.Uri.Parse("http://www.xamarin.com"));
            StartActivity(intent);
		}
	}
}