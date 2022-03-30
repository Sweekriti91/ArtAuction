using System;
using Microsoft.Maui;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace ArtAuction
{
    [Activity(Label = "ArtAuction", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : MauiAppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			// this.TabLayoutResource = Resource.Layout.Tabbar;
			// this.ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(savedInstanceState);
		}
		// public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
		// {
		// 	// Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

		// 	base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
		// }
	}
}
