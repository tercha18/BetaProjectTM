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
using Gym.Models;

namespace Gym
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    public class LoginPage : Activity
    {
        TextView loginName;
        TextView password;
        Button confirmButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.loginPage);
            confirmButton = FindViewById<Button>(Resource.Id.confirm);
            confirmButton.Click += ConfirmButton_Click;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            loginName = FindViewById<TextView>(Resource.Id.login);
            password = FindViewById<TextView>(Resource.Id.password);
            User user = new User(loginName.Text,password.Text);
            if(user.CheckInformation())
            {
                Intent intent = new Intent(this, typeof(PanelPage));
                StartActivity(intent);
            }
            else Toast.MakeText(this, "Wrong login or password", ToastLength.Short).Show();
        }
    }
}



