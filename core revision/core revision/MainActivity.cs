using Android.App;
using Android.Widget;
using Android.OS;

namespace core_revision
{
    [Activity(Label = "core_revision", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Button startbutton = FindViewById<Button>(Resource.Id.start);

            startbutton.Click += delegate {

                StartActivity(typeof(home));
            };

        }
        
    }
}

