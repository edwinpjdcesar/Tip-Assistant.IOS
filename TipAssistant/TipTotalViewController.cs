using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipAssistant
{
	partial class TipTotalViewController : UIViewController
	{
		public TipTotalViewController (IntPtr handle) : base (handle)
		{
		}

		partial void btnShow_TouchUpInside (UIButton sender)
		{
			if (NSUserDefaults.StandardUserDefaults["Tip"] != null)
			{
				string TipAmount = NSUserDefaults.StandardUserDefaults.DoubleForKey("Tip").ToString("C");
				lblTotal.Text = TipAmount;

			}
		}
	}
}
