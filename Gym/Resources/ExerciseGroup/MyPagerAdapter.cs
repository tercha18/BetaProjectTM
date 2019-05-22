using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace Gym.Resources.Group
{
    class MyPagerAdapter : FragmentPagerAdapter
    {

        public MyPagerAdapter(Android.Support.V4.App.FragmentManager fm) : base(fm)
        {

        }

        public override int Count { get { return 2; } }

        public override Android.Support.V4.App.Fragment GetItem(int position)
        {
            switch (position)
            {
                case 0: return Chest.newInstance("FirstFragment");
                case 1: return Back.newInstance("SecondFragment");
                default: return Chest.newInstance("Error");
            }
        }
        public override ICharSequence GetPageTitleFormatted(int position)
        {
            switch (position)
            {
                case 0: return new Java.Lang.String("Chest");
                case 1: return new Java.Lang.String("Back");
                default: return new Java.Lang.String("Error");
            }
        }
    }
}