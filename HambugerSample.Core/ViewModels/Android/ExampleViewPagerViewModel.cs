using System;
using System.Collections.Generic;
using System.Text;
using HambugerSample.Core.ViewModels.Base;

namespace HambugerSample.Core.ViewModels.Android
{
    public class ExampleViewPagerViewModel : BaseViewModel
    {
        public RecyclerViewModel Recycler { get; private set; }

        public ExampleViewPagerViewModel()
        {
            Recycler = new RecyclerViewModel();
        }
    }
}
