using Android.App;
using Android.OS;

namespace ViewPager
{
    [Activity(Label = "ViewPager", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.NoTitleBar")]
    public class ViewPagerActivity : Android.Support.V4.App.FragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var adapter =
                new GenericFragmentPagerAdapter(SupportFragmentManager,
                    new FragmentOne(), new FragmentTwo(), new FragmentThree());
            var viewPager = FindViewById<Android.Support.V4.View.ViewPager>(Resource.Id.viewPager);
            viewPager.Adapter = adapter;
        }
    }
}

