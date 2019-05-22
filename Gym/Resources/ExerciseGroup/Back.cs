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
    class Back : Fragment
    { 
        private string[] back = { "Wioslo", "Martwy", "Sciaganie wyciagu", "Podciaganie", "Narciarz" };
        ArrayAdapter adapter;
        private ListView exerciseList;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.groupExcerise, container, false);

            exerciseList = (ListView)view.FindViewById(Resource.Id.exer);
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, back);
            exerciseList.Adapter = adapter;
            return view;
        }

        public static Back newInstance(string text)
        {

            Back back = new Back();
            Bundle bundle = new Bundle();
            bundle.PutString("msg", text);

            back.Arguments = bundle;

            return back;
        }
    }
}