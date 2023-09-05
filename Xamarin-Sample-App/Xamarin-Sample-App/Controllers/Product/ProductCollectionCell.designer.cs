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
	[Register ("ProductCollectionCell")]
	partial class ProductCollectionCell
	{
		[Outlet]
		UIKit.UIImageView productImage { get; set; }

		[Outlet]
		UIKit.UILabel productPrice { get; set; }

		[Outlet]
		UIKit.UILabel productTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (productImage != null) {
				productImage.Dispose ();
				productImage = null;
			}

			if (productPrice != null) {
				productPrice.Dispose ();
				productPrice = null;
			}

			if (productTitle != null) {
				productTitle.Dispose ();
				productTitle = null;
			}
		}
	}
}
