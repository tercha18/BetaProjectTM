using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Gym.Models;

namespace Gym
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button loginButton;
        Button registerButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            loginButton = FindViewById<Button>(Resource.Id.login);
            loginButton.Click += LoginButton_Click;
            
        }

        private void LoginButton_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(LoginPage));
            StartActivity(intent);
        }
    }
}

