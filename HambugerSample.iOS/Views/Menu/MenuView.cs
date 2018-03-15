using Cirrious.FluentLayouts.Touch;
using CoreGraphics;
using Foundation;
using HambugerSample.Core.ViewModels.Menu;
using HambugerSample.iOS.Views.Base;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Support.XamarinSidebar;
using MvvmCross.iOS.Support.XamarinSidebar.Views;
using UIKit;

namespace HambugerSample.iOS.Views.Menu
{
    [Register("MenuView")]
	[MvxSidebarPresentation(MvxPanelEnum.Left, MvxPanelHintType.PushPanel, false)]
    public class MenuView : BaseViewController<MenuViewModel>, IMvxSidebarMenu
    {
        public virtual UIImage MenuButtonImage => UIImage.FromBundle("threelines");
        public MenuView()
        {}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var scrollView = new UIScrollView(View.Frame)
            {
                ShowsHorizontalScrollIndicator = false,
                AutoresizingMask = UIViewAutoresizing.FlexibleHeight
            };

            // create a binding set for the appropriate view model
            var set = this.CreateBindingSet<MenuView, MenuViewModel>();

            var homeButton = new UIButton(new CGRect(0, 100, 320, 40));
            homeButton.SetTitle("Home", UIControlState.Normal);
            homeButton.BackgroundColor = UIColor.White;
            homeButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            set.Bind(homeButton).To(vm => vm.ShowHomeCommand);

            var settingsButton = new UIButton(new CGRect(0, 100, 320, 40));
            settingsButton.SetTitle("Settings", UIControlState.Normal);
            settingsButton.BackgroundColor = UIColor.White;
            settingsButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            set.Bind(settingsButton).To(vm => vm.ShowSettingCommand);

            var helpButton = new UIButton(new CGRect(0, 100, 320, 40));
            helpButton.SetTitle("Help & Feedback", UIControlState.Normal);
            helpButton.BackgroundColor = UIColor.White;
            helpButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            set.Bind(helpButton).To(vm => vm.ShowHelpCommand);

            set.Apply();

            Add(scrollView);

            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            View.AddConstraints(
                scrollView.AtLeftOf(View),
                scrollView.AtTopOf(View),
                scrollView.WithSameWidth(View),
                scrollView.WithSameHeight(View));

            scrollView.Add(homeButton);
            scrollView.Add(settingsButton);
            scrollView.Add(helpButton);

            scrollView.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();

            var constraints = scrollView.VerticalStackPanelConstraints(new Margins(20, 10, 20, 10, 5, 5), scrollView.Subviews);
            scrollView.AddConstraints(constraints);
        }

        public override void ViewWillAppear(bool animated)
        {
            Title = "Left Menu View";
            base.ViewWillAppear(animated);

           
        }

        public void MenuWillOpen()
        {
            
        }

        public void MenuDidOpen()
        {
            
        }

        public void MenuWillClose()
        {
            
        }

        public void MenuDidClose()
        {
            
        }

        public virtual bool AnimateMenu => true;
        public virtual float DarkOverlayAlpha => 0;
        public virtual bool HasDarkOverlay => false;
        public virtual bool HasShadowing => true;
        public virtual float ShadowOpacity => 0.5f;
        public virtual float ShadowRadius => 4.0f;
        public virtual UIColor ShadowColor => UIColor.Black;
        public virtual bool DisablePanGesture => false;
        public virtual bool ReopenOnRotate => true;

        private int MaxMenuWidth = 300;
        private int MinSpaceRightOfTheMenu = 55;

        public int MenuWidth => UserInterfaceIdiomIsPhone ?
            int.Parse(UIScreen.MainScreen.Bounds.Width.ToString()) - MinSpaceRightOfTheMenu : MaxMenuWidth;

        private bool UserInterfaceIdiomIsPhone
        {
            get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
        }
    }
}
