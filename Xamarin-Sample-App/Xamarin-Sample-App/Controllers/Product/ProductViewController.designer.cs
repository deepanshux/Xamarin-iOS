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
	[Register ("ProductViewController")]
	partial class ProductViewController
	{
		[Outlet]
		UIKit.UICollectionView productCollectionView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (productCollectionView != null) {
				productCollectionView.Dispose ();
				productCollectionView = null;
			}
		}
	}
}
