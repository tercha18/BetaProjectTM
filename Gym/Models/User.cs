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

namespace Gym.Models
{
   public class User
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public User(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
        public bool CheckInformation()
        {
            if (userName == "admin" && password == "admin")
                return true;
            else return false;
        }
    }
}