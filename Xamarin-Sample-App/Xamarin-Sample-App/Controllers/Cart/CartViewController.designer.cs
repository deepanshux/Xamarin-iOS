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
	[Register ("CartViewController")]
	partial class CartViewController
	{
		[Outlet]
		UIKit.UITableView cartTableView { get; set; }

		[Outlet]
		UIKit.UIButton checkoutBtn { get; set; }

		[Outlet]
		UIKit.UIImageView emptyCartImageView { get; set; }

		[Outlet]
		UIKit.UILabel totalPriceLabel { get; set; }

		[Action ("checkoutTap:")]
		partial void checkoutTap (Foundation.NSObject sender);

		[Action ("StepperAction:")]
		partial void StepperAction (UIKit.UIStepper sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (cartTableView != null) {
				cartTableView.Dispose ();
				cartTableView = null;
			}

			if (emptyCartImageView != null) {
				emptyCartImageView.Dispose ();
				emptyCartImageView = null;
			}

			if (totalPriceLabel != null) {
				totalPriceLabel.Dispose ();
				totalPriceLabel = null;
			}

			if (checkoutBtn != null) {
				checkoutBtn.Dispose ();
				checkoutBtn = null;
			}
		}
	}
}
