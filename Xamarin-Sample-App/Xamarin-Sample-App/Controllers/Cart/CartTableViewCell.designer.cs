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
	[Register ("CartTableViewCell")]
	partial class CartTableViewCell
	{
		[Outlet]
		UIKit.UIImageView productImage { get; set; }

		[Outlet]
		UIKit.UILabel productName { get; set; }

		[Outlet]
		UIKit.UILabel productPrice { get; set; }

		[Outlet]
		UIKit.UILabel quantityLabel { get; set; }

		[Outlet]
		UIKit.UIStepper stepper { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (productImage != null) {
				productImage.Dispose ();
				productImage = null;
			}

			if (productName != null) {
				productName.Dispose ();
				productName = null;
			}

			if (productPrice != null) {
				productPrice.Dispose ();
				productPrice = null;
			}

			if (stepper != null) {
				stepper.Dispose ();
				stepper = null;
			}

			if (quantityLabel != null) {
				quantityLabel.Dispose ();
				quantityLabel = null;
			}
		}
	}
}
