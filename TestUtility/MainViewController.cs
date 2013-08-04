using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DataModel;
using DataModel.Interfaces;

namespace TestUtility
{
	public partial class MainViewController : UIViewController
	{
		ICalculationModel _model;
		public MainViewController (ICalculationModel model) : base ("MainViewController", null)
		{
			_model = model;
			// Custom initialization
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			calculatiomParameters.DataSource = new CalculationDataSource (_model);
			calculatiomParameters.Delegate = new CalculationDelegate ();
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		partial void showInfo (NSObject sender)
		{
			var controller = new FlipsideViewController () {
				ModalTransitionStyle = UIModalTransitionStyle.FlipHorizontal,
			};
			
			controller.Done += delegate {
				DismissModalViewControllerAnimated (true);
			};
			
			PresentModalViewController (controller, true);
		}
	}
}

