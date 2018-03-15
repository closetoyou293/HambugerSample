using HambugerSample.Core.Interfaces;
using HambugerSample.iOS.Services;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.ViewModels.Hints;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Support.XamarinSidebar;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using MvvmCross.Platform.Platform;
using UIKit;

namespace HambugerSample.iOS
{
    public class Setup : MvxIosSetup
    {
        public Setup(IMvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
        {
        }
        
        public Setup(IMvxApplicationDelegate applicationDelegate, IMvxIosViewPresenter presenter)
            : base(applicationDelegate, presenter)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new Core.App();
        }
        protected override IMvxIosViewPresenter CreatePresenter()
        {
            var presenter = new MvxSidebarPresenter((MvxApplicationDelegate)ApplicationDelegate, Window);

           

            return presenter;
        }
        protected override IMvxTrace CreateDebugTrace()
        {
            return new DebugTrace();
        }

        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterSingleton<IDialogService>(() => new TouchDialogService());
            //register the presentation hint to pop to root
            //picked up in the third view model
            Mvx.RegisterSingleton<MvxPresentationHint>(() => new MvxPopToRootPresentationHint());
        }
    }
}
