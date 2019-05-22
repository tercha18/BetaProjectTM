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
    public class MyTraining
    {
        string name { get; set; }
        List<string> items = new List<string>();

        public MyTraining(string name)
        {
            this.name = name;
        }

        public void AddExercise(string name)
        {
            this.items.Add(name);
        }

    }
}