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
		public UIKit.UIImageView ImageViewFacility { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageViewNext { get; set; }

		[Outlet]
        public UIKit.UILabel LabelFacility { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ImageViewFacility != null) {
				ImageViewFacility.Dispose ();
				ImageViewFacility = null;
			}

			if (LabelFacility != null) {
				LabelFacility.Dispose ();
				LabelFacility = null;
			}

			if (ImageViewNext != null) {
				ImageViewNext.Dispose ();
				ImageViewNext = null;
			}
		}
	}
}
