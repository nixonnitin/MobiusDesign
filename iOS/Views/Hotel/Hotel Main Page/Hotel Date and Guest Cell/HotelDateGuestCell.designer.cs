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
	[Register ("HotelDateGuestCell")]
	partial class HotelDateGuestCell
	{
		[Outlet]
		public UIKit.UIButton ButtonDates { get; set; }

		[Outlet]
        public UIKit.UIButton ButtonGuests { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageError { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageViewDates { get; set; }

		[Outlet]
        public UIKit.UIImageView ImageViewGuests { get; set; }

		[Outlet]
        public UIKit.UILabel LabelDates { get; set; }

		[Outlet]
        public UIKit.UILabel LabelError { get; set; }

		[Outlet]
        public UIKit.UILabel LabelGuests { get; set; }

		[Outlet]
        public UIKit.UILabel LabelSelectedDate { get; set; }

		[Outlet]
        public UIKit.UILabel LabelSelectedGuests { get; set; }

		[Outlet]
        public UIKit.UIView ViewButtonDates { get; set; }

		[Outlet]
        public UIKit.UIView ViewButtonGuests { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelError != null) {
				LabelError.Dispose ();
				LabelError = null;
			}

			if (ImageError != null) {
				ImageError.Dispose ();
				ImageError = null;
			}

			if (ViewButtonDates != null) {
				ViewButtonDates.Dispose ();
				ViewButtonDates = null;
			}

			if (ViewButtonGuests != null) {
				ViewButtonGuests.Dispose ();
				ViewButtonGuests = null;
			}

			if (ImageViewDates != null) {
				ImageViewDates.Dispose ();
				ImageViewDates = null;
			}

			if (ImageViewGuests != null) {
				ImageViewGuests.Dispose ();
				ImageViewGuests = null;
			}

			if (LabelDates != null) {
				LabelDates.Dispose ();
				LabelDates = null;
			}

			if (LabelSelectedDate != null) {
				LabelSelectedDate.Dispose ();
				LabelSelectedDate = null;
			}

			if (LabelGuests != null) {
				LabelGuests.Dispose ();
				LabelGuests = null;
			}

			if (LabelSelectedGuests != null) {
				LabelSelectedGuests.Dispose ();
				LabelSelectedGuests = null;
			}

			if (ButtonDates != null) {
				ButtonDates.Dispose ();
				ButtonDates = null;
			}

			if (ButtonGuests != null) {
				ButtonGuests.Dispose ();
				ButtonGuests = null;
			}
		}
	}
}
