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

namespace core_revision
{
    [Activity(Label = "mathmenu")]
    public class mathmenu : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Button basicmathlink = FindViewById<Button>(Resource.Id.basicmathlink);
            basicmathlink.Click += delegate {

                StartActivity(typeof(mathmenu));
            };
        }
    }
}