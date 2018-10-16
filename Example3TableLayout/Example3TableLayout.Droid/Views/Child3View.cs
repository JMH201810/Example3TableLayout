using Android.App;
using Android.OS;
using Android.Support.V7.Widget;
using Example3TableLayout.Core.ViewModels;
using MvvmCross.Droid.Support.V7.AppCompat;
using Android.Views;

namespace Example3TableLayout.Droid.Views
{
    [Activity(Label = "Child3View")]
    public class Child3View : MvxAppCompatActivity<Child3ViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here
            SetContentView(Resource.Layout.child3_view);

            var toolbar = FindViewById<Toolbar>(Resource.Id.toolbar3);
            SetSupportActionBar(toolbar);

            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    ViewModel.ExampleReturnCommand.Execute(null);
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}
