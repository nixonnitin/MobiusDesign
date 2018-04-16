// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mobius.iOS.Views
{
	[Register ("HotelMoreCell")]
	partial class HotelMoreCell
	{
		[Outlet]
		UIKit.UIImageView ImageViewDone { get; set; }

		[Outlet]
		public UIKit.UIImageView ImageViewFacility { get; private set; }

		[Outlet]
		public UIKit.UIImageView ImageViewNext { get; private set; }

		[Outlet]
		public UIKit.UILabel LabelFacility { get; private set; }

		[Outlet]
	    public UIKit.UILabel LabelPErcentageLeft { get; set; }

		[Outlet]
		public UIKit.UIProgressView ProgressBarStatusCompletePerc { get; set; }

		[Outlet]
        public UIKit.UIView ViewLabelAndImage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageViewFacility != null) {
				ImageViewFacility.Dispose ();
				ImageViewFacility = null;
			}

			if (ImageViewNext != null) {
				ImageViewNext.Dispose ();
				ImageViewNext = null;
			}

			if (LabelFacility != null) {
				LabelFacility.Dispose ();
				LabelFacility = null;
			}

			if (ViewLabelAndImage != null) {
				ViewLabelAndImage.Dispose ();
				ViewLabelAndImage = null;
			}

			if (ImageViewDone != null) {
				ImageViewDone.Dispose ();
				ImageViewDone = null;
			}

			if (LabelPErcentageLeft != null) {
				LabelPErcentageLeft.Dispose ();
				LabelPErcentageLeft = null;
			}

			if (ProgressBarStatusCompletePerc != null) {
				ProgressBarStatusCompletePerc.Dispose ();
				ProgressBarStatusCompletePerc = null;
			}
		}
	}
}
