using System;
using System.Collections.Generic;
using System.Text;
using HambugerSample.Core.ViewModels.Android;
using HambugerSample.Core.ViewModels.Base;
using MvvmCross.Core.ViewModels;

namespace HambugerSample.Core.ViewModels.Home
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            Recycler = new RecyclerViewModel();
        }

        /// <summary>Gets the recycler.</summary>
        /// <value>The recycler.</value>
        public RecyclerViewModel Recycler { get; private set; }

        public MvxCommand GoToInfoCommand
        {
            get { return new MvxCommand(() => ShowViewModel<InfoViewModel>()); }
        }
    }
}
