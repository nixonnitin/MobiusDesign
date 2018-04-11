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
	[Register ("HotelListCell")]
	partial class HotelListCell
	{
		[Outlet]
		public UIKit.UIImageView ImageViewNext { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageViewRoom { get; set; }

		[Outlet]
        public UIKit.UILabel LabelPricePerNight { get; set; }

		[Outlet]
        public UIKit.UILabel LabelRoomType { get; set; }

		[Outlet]
        public UIKit.UIView ViewMain { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ViewMain != null) {
				ViewMain.Dispose ();
				ViewMain = null;
			}

			if (ImageViewRoom != null) {
				ImageViewRoom.Dispose ();
				ImageViewRoom = null;
			}

			if (LabelRoomType != null) {
				LabelRoomType.Dispose ();
				LabelRoomType = null;
			}

			if (ImageViewNext != null) {
				ImageViewNext.Dispose ();
				ImageViewNext = null;
			}

			if (LabelPricePerNight != null) {
				LabelPricePerNight.Dispose ();
				LabelPricePerNight = null;
			}
		}
	}
}
