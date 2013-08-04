// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace TestUtility
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		MonoTouch.UIKit.UITableView calculatiomParameters { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIStepper plusMinus { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel text { get; set; }

		[Action ("Calculate:")]
		partial void Calculate (MonoTouch.Foundation.NSObject sender);

		[Action ("showInfo:")]
		partial void showInfo (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (plusMinus != null) {
				plusMinus.Dispose ();
				plusMinus = null;
			}

			if (text != null) {
				text.Dispose ();
				text = null;
			}

			if (calculatiomParameters != null) {
				calculatiomParameters.Dispose ();
				calculatiomParameters = null;
			}
		}
	}
}
