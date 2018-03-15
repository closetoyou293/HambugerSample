using Cirrious.FluentLayouts.Touch;
using Foundation;
using HambugerSample.Core.ViewModels.Home;
using HambugerSample.iOS.Views.Base;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Support.XamarinSidebar;
using UIKit;

namespace HambugerSample.iOS.Views.Home
{
    [Register("InfoView")]
	[MvxSidebarPresentation(MvxPanelEnum.Center, MvxPanelHintType.PushPanel, true,MvxSplitViewBehaviour.Detail)]
    public class InfoView : BaseViewController<InfoViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var viewModel = this.ViewModel;

            var scrollView = new UIScrollView(View.Frame)
            {
                ShowsHorizontalScrollIndicator = false,
                AutoresizingMask = UIViewAutoresizing.FlexibleHeight
            };
            var label = new UILabel();
            label.Text = "Info View";
            var thirdButton = new UIButton();
            thirdButton.SetTitle("Show Third ViewModel", UIControlState.Normal);
            thirdButton.BackgroundColor = UIColor.Blue;
            scrollView.AddSubviews(label, thirdButton);

            Add(scrollView);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            View.AddConstraints(
                scrollView.AtLeftOf(View),
                scrollView.AtTopOf(View),
                scrollView.WithSameWidth(View),
                scrollView.WithSameHeight(View));
            scrollView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            var set = this.CreateBindingSet<InfoView, InfoViewModel>();
            set.Bind(thirdButton).To(vm => vm.ShowThirdViewModelCommand);
            set.Apply();

            scrollView.AddConstraints(

                label.Below(scrollView).Plus(10),
                label.WithSameWidth(scrollView),
                label.WithSameLeft(scrollView),

                thirdButton.Below(label).Plus(10),
                thirdButton.WithSameWidth(label),
                thirdButton.WithSameLeft(label)
                );

        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Info View";
            base.ViewWillAppear(animated);
        }
    }
}
