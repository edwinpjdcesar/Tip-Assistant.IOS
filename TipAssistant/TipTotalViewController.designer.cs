// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TipAssistant
{
	[Register ("TipTotalViewController")]
	partial class TipTotalViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnShow { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTotal { get; set; }

		[Action ("btnShow_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnShow_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnShow != null) {
				btnShow.Dispose ();
				btnShow = null;
			}
			if (lblTotal != null) {
				lblTotal.Dispose ();
				lblTotal = null;
			}
		}
	}
}
