using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using Gym.Models;

namespace Gym
{
    [Activity(Label = "PanelPage", Theme = "@style/AppTheme")]
    public class PanelPage : Activity
    {

        ImageButton ImageButtonGuide;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.panelPage);
            ImageButtonGuide = FindViewById<ImageButton>(Resource.Id.imageButtonGuide);
            ImageButtonGuide.Click += delegate
            {
                Intent intent = new Intent(this, typeof(Exercises));
                StartActivity(intent);
            };
        }

    }
}