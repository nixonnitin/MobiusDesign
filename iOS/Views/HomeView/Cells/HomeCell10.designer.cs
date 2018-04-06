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
	[Register ("HomeCell10")]
	partial class HomeCell10
	{
		[Outlet]
		public UIKit.NSLayoutConstraint ConstraintSelectedViewWidth { get; private set; }

		[Outlet]
		public UIKit.UILabel LabelPointsDetail { get; private set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ConstraintSelectedViewWidth != null) {
				ConstraintSelectedViewWidth.Dispose ();
				ConstraintSelectedViewWidth = null;
			}

			if (LabelPointsDetail != null) {
				LabelPointsDetail.Dispose ();
				LabelPointsDetail = null;
			}
		}
	}
}
