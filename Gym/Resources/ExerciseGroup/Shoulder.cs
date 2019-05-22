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

namespace Gym.Resources.ExerciseGroup
{
    class Shoulder : Fragment
    {
        private ListView exerciseList;
        private string[] shoulder = { "Wyciskanie hantli", "Wyciskanie żołnierskie", "Wznosy hantla", "Wznosy linka", "Szrugsy" };
        private ArrayAdapter adapter;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.groupExcerise, container, false);
            exerciseList = view.FindViewById<ListView>(Resource.Id.exer);
            adapter = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, shoulder);
            exerciseList.Adapter = adapter;
            
            return view;
        }

        public static Shoulder newInstance(string text)
        {

            Shoulder shoulder = new Shoulder();
            Bundle bundle = new Bundle();
            bundle.PutString("msg", text);

            shoulder.Arguments = bundle;

            return shoulder;
        }
    }
}