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
    [Activity(Label = "home")]
    public class home : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.homelayout);
            // Create your application here
            Button mathlink = FindViewById<Button>(Resource.Id.mathlink);
            mathlink.Click += (object sender, EventArgs e) =>
            {

                StartActivity(typeof(mathmenu));
            };
        }
    }
}