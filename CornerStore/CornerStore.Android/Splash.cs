using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FFImageLoading.Forms.Droid;

namespace CornerStore.Droid
{
    [Activity(Label = "CornerStore", Icon = "@mipmap/icon", Theme = "@style/MyTheme",NoHistory =true, MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class Splash:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //CachedImageRenderer.Init(true);
            StartActivity(typeof(MainActivity));
            Finish();
            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}