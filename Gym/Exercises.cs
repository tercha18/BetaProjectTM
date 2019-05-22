using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Support.V4.View;
using Android.Views;
using Android.Support.V4.App;
using System;
using Java.Lang;
using Gym.Resources.Group;

namespace Gym
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class Exercises : FragmentActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            
            ViewPager pager = (ViewPager)FindViewById(Resource.Id.viewpager);
            pager.Adapter = (new MyPagerAdapter(SupportFragmentManager));

        }
    }
}
