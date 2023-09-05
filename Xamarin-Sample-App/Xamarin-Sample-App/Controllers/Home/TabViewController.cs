// This file has been autogenerated from a class added in the UI designer.

using System;
using Foundation;
using UIKit;

namespace Xamarin_Sample_App
{
	public partial class TabViewController : UITabBarController
	{
		public TabViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            NavigationItem.SetHidesBackButton(true, animated: true);
            NavigationController.SetNavigationBarHidden(true, true);
        }
    }
}