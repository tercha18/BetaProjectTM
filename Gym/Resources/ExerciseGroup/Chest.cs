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

namespace Gym.Resources.Group
{
    class Chest : Fragment
    {
        private string[] chest = { "Wyciskanie plaska", "Rozpietki", "Spietki", "Wyciskanie hantle", "Wyciskanie skos" };
        private ArrayAdapter adapter;
        private ListView exerciseList;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.groupExcerise, container, false);

            exerciseList = (ListView)view.FindViewById(Resource.Id.exer);
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, chest);
            exerciseList.Adapter = adapter;
            return view;
        }

        public static Chest newInstance(string text)
        {

            Chest chest = new Chest();
            Bundle bundle = new Bundle();
            bundle.PutString("msg", text);

            chest.Arguments = bundle;

            return chest;
        }
    }
}