using Foundation;
using HambugerSample.Core.ViewModels.Base;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace HambugerSample.iOS.Views.Base
{
    [Register("MainView")]
	[MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true,MvxSplitViewBehaviour.Master)]
    public class MainView : BaseViewController<MainViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ViewModel.ShowMenu();
        }
    }   
}