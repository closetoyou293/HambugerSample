﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using HambugerSample.Core.ViewModels.Base;
using HambugerSample.Core.ViewModels.Menu;
using HambugerSample.Droid.Activities;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;

namespace HambugerSample.Droid.Fragments.Menu
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.navigation_frame)]
    [Register("hambugersample.droid.fragments.MenuFragment")]
    public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;
        private IMenuItem _previousMenuItem;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.fragment_navigation, null);

            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);
            _navigationView.Menu.FindItem(Resource.Id.nav_home).SetChecked(true);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            if (item != _previousMenuItem)
            {
                _previousMenuItem?.SetChecked(false);
            }

            item.SetCheckable(true);
            item.SetChecked(true);

            _previousMenuItem = item;

            Navigate(item.ItemId);

            return true;
        }

        private async Task Navigate(int itemId)
        {
            ((MainActivity)Activity).DrawerLayout.CloseDrawers();

            // add a small delay to prevent any UI issues
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            switch (itemId)
            {
                case Resource.Id.nav_home:
                    ViewModel.ShowHomeCommand.Execute();
                    break;
                case Resource.Id.nav_viewpager:
                    ViewModel.ShowViewPagerCommand.Execute();
                    break;
                case Resource.Id.nav_recyclerview:
                    ViewModel.ShowRecyclerCommand.Execute();
                    break;
                case Resource.Id.nav_settings:
                    ViewModel.ShowSettingCommand.Execute();
                    break;
                case Resource.Id.nav_helpfeedback:
                    ViewModel.ShowHelpCommand.Execute();
                    break;
            }
        }
    }
}