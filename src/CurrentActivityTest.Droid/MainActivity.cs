﻿using Android.App;
using Android.Widget;
using Android.OS;
using Plugin.CurrentActivity;

namespace CurrentActivityTest
{
	[Activity(Label = "CurrentActivityTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			CrossCurrentActivity.Current.Init(this, bundle);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);


            button.Click += delegate 
                {
                    StartActivity(typeof(SecondActivity));
                };
        }
	}
}

