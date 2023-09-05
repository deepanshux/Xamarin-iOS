// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamarin_Sample_App
{
	[Register ("PaymentViewController")]
	partial class PaymentViewController
	{
		[Outlet]
		UIKit.UITextField cardNumberField { get; set; }

		[Outlet]
		UIKit.UITextField cvvField { get; set; }

		[Outlet]
		UIKit.UITextField emailField { get; set; }

		[Outlet]
		UIKit.UIPickerView monthPickerView { get; set; }

		[Outlet]
		UIKit.UILabel payPriceLabel { get; set; }

		[Outlet]
		UIKit.UIPickerView yearPickerView { get; set; }

		[Action ("OtherControlsTap:")]
		partial void OtherControlsTap (Foundation.NSObject sender);

		[Action ("PayTap:")]
		partial void PayTap (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (cardNumberField != null) {
				cardNumberField.Dispose ();
				cardNumberField = null;
			}

			if (cvvField != null) {
				cvvField.Dispose ();
				cvvField = null;
			}

			if (emailField != null) {
				emailField.Dispose ();
				emailField = null;
			}

			if (monthPickerView != null) {
				monthPickerView.Dispose ();
				monthPickerView = null;
			}

			if (payPriceLabel != null) {
				payPriceLabel.Dispose ();
				payPriceLabel = null;
			}

			if (yearPickerView != null) {
				yearPickerView.Dispose ();
				yearPickerView = null;
			}
		}
	}
}
