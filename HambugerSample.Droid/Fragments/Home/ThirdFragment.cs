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
using HambugerSample.Core.ViewModels.Base;
using HambugerSample.Core.ViewModels.Home;
using HambugerSample.Droid.Activities;
using HambugerSample.Droid.Fragments.Base;
using MvvmCross.Droid.Views.Attributes;

namespace HambugerSample.Droid.Fragments.Home
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
    [Register("hambugersample.droid.fragments.ThirdFragment")]
    public class ThirdFragment : BaseFragment<ThirdViewModel>
    {
        string oldTitle;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            oldTitle = ((MainActivity)Activity).Title;
            ((MainActivity)Activity).Title = "Third Fragment";
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        public override void OnDestroyView()
        {
            ((MainActivity)Activity).Title = oldTitle;
            base.OnDestroyView();
        }

        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.fragment_third;
            }
        }
    }
}