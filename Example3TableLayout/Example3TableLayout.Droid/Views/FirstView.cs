using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Example3TableLayout.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace Example3TableLayout.Droid.Views
{
    [Activity(Label = "Front Screen")]
    public class FirstView : MvxAppCompatActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FirstView);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}
