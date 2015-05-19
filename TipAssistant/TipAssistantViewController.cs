using System;
using System.Drawing;

using Foundation;
using UIKit;

namespace TipAssistant
{
	public partial class TipAssistantViewController : UIViewController
	{
		double dblBillTotal;
		double dblTipPercent;

		public TipAssistantViewController (IntPtr handle) : base (handle)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			//	do some stuff
			txtBill.Placeholder = "Enter bill here..";
			txtBill.KeyboardType = UIKeyboardType.NumberPad;
			txtBill.ReturnKeyType = UIReturnKeyType.Next;

		}

		partial void btnGo_TouchUpInside (UIButton sender)
		{

			double.TryParse(txtBill.Text, out dblBillTotal).ToString();

			// do more stuff
			if (TipSlider.Value >= .1 && dblBillTotal > 0)
			{
				dblTipPercent = TipSlider.Value/100;

				double dblTipTotal = dblBillTotal*dblTipPercent;

				NSUserDefaults.StandardUserDefaults.SetDouble(dblTipTotal,"Tip");
				NSUserDefaults.StandardUserDefaults.Synchronize();

			}
			else if (TipSlider.Value == 0)
			{
				UIAlertView error = new UIAlertView("Aren't you forgetting something?",
					"You didn't put a tip..",
					null,
					"Ok",
					null);
				error.Show();
			}
			else
			{
				UIAlertView error = new UIAlertView("Aren't you forgetting something?",
					"You didn't put a bill total..",
					null,
					"Ok",
					null);
				error.Show();
			}
		}

		partial void TipSlider_ValueChanged (UISlider sender)
		{
			lblTip.Text = (TipSlider.Value/100).ToString("P");

			if (TipSlider.Value == 100)
			{
				lblComment.Text = "You better get their number after this..";
			}
			else if (TipSlider.Value >= 75)
			{
				lblComment.Text = "Ok buddy, let's take it easy.";
			}
			else if (TipSlider.Value >= 50)
			{
				lblComment.Text = "You're the man!";
			}
			else if (TipSlider.Value >= 15)
			{
				lblComment.Text = "That's more like it!";
			}
			else
				lblComment.Text = "Wow, don't be so stingy..";

		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion
	}
}

