using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HambugerSample.Core.ViewModels.Login;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace HambugerSample.Droid.Activities
{
    [Activity(
        Label = "Examples",
        Theme = "@style/AppTheme.Login",
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize,
        Name = "hambugersample.droid.activities.LoginActivity"
    )]
    public class LoginActivity : MvxAppCompatActivity<LoginViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_login);
        }
    }
}