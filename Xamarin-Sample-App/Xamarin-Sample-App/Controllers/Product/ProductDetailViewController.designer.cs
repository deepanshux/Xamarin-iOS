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
	[Register ("ProductDetailViewController")]
	partial class ProductDetailViewController
	{
		[Outlet]
		UIKit.UIButton AddToCartButton { get; set; }

		[Outlet]
		UIKit.UITextView productDescription { get; set; }

		[Outlet]
		UIKit.UIImageView productDetailImage { get; set; }

		[Outlet]
		UIKit.UILabel productDetailPrice { get; set; }

		[Outlet]
		UIKit.UILabel productDetailTitle { get; set; }

		[Action ("AddToCartTap:")]
		partial void AddToCartTap (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (productDescription != null) {
				productDescription.Dispose ();
				productDescription = null;
			}

			if (productDetailImage != null) {
				productDetailImage.Dispose ();
				productDetailImage = null;
			}

			if (productDetailPrice != null) {
				productDetailPrice.Dispose ();
				productDetailPrice = null;
			}

			if (productDetailTitle != null) {
				productDetailTitle.Dispose ();
				productDetailTitle = null;
			}

			if (AddToCartButton != null) {
				AddToCartButton.Dispose ();
				AddToCartButton = null;
			}
		}
	}
}
