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
	[Register ("LoginViewController")]
	partial class LoginViewController
	{
		[Outlet]
		UIKit.UITextField passwordField { get; set; }

		[Outlet]
		UIKit.UITextField usernameField { get; set; }

		[Action ("loginButton:")]
		partial void loginButton (Foundation.NSObject sender);

		[Action ("signUpButton:")]
		partial void signUpButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (usernameField != null) {
				usernameField.Dispose ();
				usernameField = null;
			}

			if (passwordField != null) {
				passwordField.Dispose ();
				passwordField = null;
			}
		}
	}
}
