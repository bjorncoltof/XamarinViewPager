using System;
using Android.App;
using Android.Support.V13.App;

namespace ViewPager
{
  public class GenericFragmentPagerAdapter : Android.Support.V13.App.FragmentPagerAdapter
    {
        private readonly Fragment[] _fragments;

        public GenericFragmentPagerAdapter(
            FragmentManager fm,
            params Fragment[] fragments) : base(fm)
        {
            _fragments = fragments;
        }

        public override int Count
        {
            get { return _fragments.Length; }
        }

        public override Fragment GetItem(int position)
        {
            return _fragments[position];
        }

        public override Java.Lang.ICharSequence GetPageTitleFormatted(int position)
        {
            var title = String.Format("Tab {0}", position + 1);
            return new Java.Lang.String(title);
        }
    }
}