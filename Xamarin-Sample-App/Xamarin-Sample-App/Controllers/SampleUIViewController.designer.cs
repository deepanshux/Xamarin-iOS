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
	[Register ("SampleUIViewController")]
	partial class SampleUIViewController
	{
		[Outlet]
		UIKit.UIColorWell colorWell { get; set; }

		[Outlet]
		UIKit.UISlider slider { get; set; }

		[Outlet]
		UIKit.UILabel sliderLabel { get; set; }

		[Action ("colorWellAction:")]
		partial void colorWellAction (Foundation.NSObject sender);

		[Action ("SliderAction:")]
		partial void SliderAction (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (slider != null) {
				slider.Dispose ();
				slider = null;
			}

			if (sliderLabel != null) {
				sliderLabel.Dispose ();
				sliderLabel = null;
			}

			if (colorWell != null) {
				colorWell.Dispose ();
				colorWell = null;
			}
		}
	}
}
