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
	[Register ("TipAssistantViewController")]
	partial class TipAssistantViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnGo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblComment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel lblTip { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISlider TipSlider { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtBill { get; set; }

		[Action ("btnGo_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnGo_TouchUpInside (UIButton sender);

		[Action ("TipSlider_ValueChanged:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void TipSlider_ValueChanged (UISlider sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnGo != null) {
				btnGo.Dispose ();
				btnGo = null;
			}
			if (lblComment != null) {
				lblComment.Dispose ();
				lblComment = null;
			}
			if (lblTip != null) {
				lblTip.Dispose ();
				lblTip = null;
			}
			if (TipSlider != null) {
				TipSlider.Dispose ();
				TipSlider = null;
			}
			if (txtBill != null) {
				txtBill.Dispose ();
				txtBill = null;
			}
		}
	}
}
