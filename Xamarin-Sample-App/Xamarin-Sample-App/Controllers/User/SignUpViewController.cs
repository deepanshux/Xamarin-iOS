// This file has been autogenerated from a class added in the UI designer.

using System;
using Xamarin_Sample_App.Home;
using Foundation;
using UIKit;
using KountDataCollector;
namespace Xamarin_Sample_App
{
	public partial class SignUpViewController : KountAnalyticsViewController
	{
        UITabBarController tabBarController;

        public SignUpViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            NavigationItem.SetHidesBackButton(true, animated: true);
            DismissKeyboard();
        }

        public override void AwakeFromNib()
        {
            this.Initialize();
        }

        private void Initialize()
        {
            tabBarController = Storyboard.InstantiateViewController("TabViewController") as TabViewController;
        }

        partial void signInButton(NSObject sender)
        {
            NavigateToLogin();
        }

        partial void signUpButton(NSObject sender)
        {
            NavigateToHome();
        }

        private void NavigateToLogin()
        {
            this.NavigationController.PopViewController(true);
        }

        private void NavigateToHome()
        {
            this.NavigationController.PushViewController(tabBarController, true);
        }

        private void DismissKeyboard()
        {
            // Dismiss the keyboard if taps anywhere in the view.
            var gesture = new UITapGestureRecognizer(() =>
              View.EndEditing(true));
            View.AddGestureRecognizer(gesture);
        }
    }
}
