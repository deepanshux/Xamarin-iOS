// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamarin_Sample_App.Home
{
	[Register ("CategoryCollectionViewCell")]
	partial class CategoryCollectionViewCell
    {
		[Outlet]
		UIKit.UIImageView collectionImageView { get; set; }

		[Outlet]
		UIKit.UILabel itemLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (collectionImageView != null) {
				collectionImageView.Dispose ();
				collectionImageView = null;
			}

			if (itemLabel != null) {
				itemLabel.Dispose ();
				itemLabel = null;
			}
		}
	}
}
