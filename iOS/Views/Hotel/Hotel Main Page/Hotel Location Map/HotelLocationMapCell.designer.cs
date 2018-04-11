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
	[Register ("HotelLocationMapCell")]
	partial class HotelLocationMapCell
	{
		[Outlet]
		public UIKit.UIImageView ImageViewLocation { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageViewLocationView { get; set; }

		[Outlet]
        public UIKit.UILabel LabelAddress { get; set; }

		[Outlet]
        public UIKit.UILabel LabelLocation { get; set; }

		[Outlet]
        public UIKit.UIView ViewMain { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ViewMain != null) {
				ViewMain.Dispose ();
				ViewMain = null;
			}

			if (ImageViewLocationView != null) {
				ImageViewLocationView.Dispose ();
				ImageViewLocationView = null;
			}

			if (ImageViewLocation != null) {
				ImageViewLocation.Dispose ();
				ImageViewLocation = null;
			}

			if (LabelLocation != null) {
				LabelLocation.Dispose ();
				LabelLocation = null;
			}

			if (LabelAddress != null) {
				LabelAddress.Dispose ();
				LabelAddress = null;
			}
		}
	}
}
