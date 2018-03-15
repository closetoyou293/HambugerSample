using Foundation;
using HambugerSample.Core.ViewModels.Help;
using HambugerSample.iOS.Views.Base;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace HambugerSample.iOS.Views.Help
{
    [Register("HelpView")]
    [MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class HelpView : BaseViewController<HelpAndFeedbackViewModel>
    {
        public override void ViewWillAppear(bool animated)
        {
            Title = "Help View";
            base.ViewWillAppear(animated);
        }
    }
}
