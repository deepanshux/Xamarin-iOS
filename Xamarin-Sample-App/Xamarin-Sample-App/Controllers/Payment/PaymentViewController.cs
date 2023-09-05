// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using UIKit;

namespace Xamarin_Sample_App
{
	public partial class PaymentViewController : UIViewController
	{
		public PaymentViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            SetPickerView();
            DismissKeyboard();
        }

        partial void PayTap(NSObject sender)
        {
            ShowAlert();
        }

        partial void OtherControlsTap(NSObject sender)
        {
            NavigateToOtherControlsVC();
        }

        private void SetPickerView()
        {
            monthPickerView.Tag = 1;
            yearPickerView.Tag = 2;
            var pickerModel = new PickerModel();
            monthPickerView.Model = pickerModel;
            yearPickerView.Model = pickerModel;
        }

        private void NavigateToHome()
        {
            var tabBarController = Storyboard.InstantiateViewController("TabViewController") as TabViewController;
            this.NavigationController.PushViewController(tabBarController, true);
        }

        private void ShowAlert()
        {
            var alert = UIAlertController.Create("Successful", "Your payment has been successful", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Shop more", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }

        private void NavigateToOtherControlsVC()
        {
            var sampleUIController = Storyboard.InstantiateViewController("SampleUIViewController") as SampleUIViewController;
            this.NavigationController.PushViewController(sampleUIController, true);
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