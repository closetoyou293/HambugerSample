﻿using System;
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
using HambugerSample.Core.ViewModels.Settings;
using HambugerSample.Droid.Fragments.Base;
using MvvmCross.Droid.Views.Attributes;

namespace HambugerSample.Droid.Fragments.Settings
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("hambugersample.droid.fragments.SettingsFragment")]
    public class SettingsFragment : BaseFragment<SettingsViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ShowHamburgerMenu = true;
            return base.OnCreateView(inflater, container, savedInstanceState);
        }

        protected override int FragmentId => Resource.Layout.fragment_settings;
    }
}