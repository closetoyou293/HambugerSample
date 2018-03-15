using Foundation;
using HambugerSample.Core.ViewModels.Settings;
using HambugerSample.iOS.Views.Base;
using MvvmCross.iOS.Support.XamarinSidebar;

namespace HambugerSample.iOS.Views.Settings
{
    [Register("SettingsView")]
	[MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.ResetRoot, true)]
    public class SettingsView : BaseViewController<SettingsViewModel>
    {
        public override void ViewWillAppear(bool animated)
        {
            Title = "Settings View";
            base.ViewWillAppear(animated);
        }
    }
}
