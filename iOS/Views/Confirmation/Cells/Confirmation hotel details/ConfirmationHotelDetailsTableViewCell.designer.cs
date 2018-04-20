// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Mobius.iOS.Views
{
    [Register ("ConfirmationHotelDetailsTableViewCell")]
    partial class ConfirmationHotelDetailsTableViewCell
    {
        [Outlet]
        public UIKit.UIButton ButtonHotelImageEdit { get; private set; }

        [Outlet]
        public UIKit.UIButton CheckInButton { get; private set; }

        [Outlet]
        public UIKit.UIImageView ImageHotelRoomrate { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelHotelName { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelHotelPlace { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelHotelPrice { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelInnerLimitedTimeOffer { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelTotalForStay { get; private set; }

        [Outlet]
        public UIKit.UIView LblLimitedTimeOffer { get; private set; }

        [Outlet]
        public UIKit.UIView ViewBottomSeparater { get; set; }

        [Outlet]
        public UIKit.UIView ViewMain { get; private set; }

        [Outlet]
        public UIKit.UIView ViewTopSeparater { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonHotelImageEdit != null) {
                ButtonHotelImageEdit.Dispose ();
                ButtonHotelImageEdit = null;
            }

            if (ImageHotelRoomrate != null) {
                ImageHotelRoomrate.Dispose ();
                ImageHotelRoomrate = null;
            }

            if (LabelHotelName != null) {
                LabelHotelName.Dispose ();
                LabelHotelName = null;
            }

            if (LabelHotelPlace != null) {
                LabelHotelPlace.Dispose ();
                LabelHotelPlace = null;
            }

            if (LabelHotelPrice != null) {
                LabelHotelPrice.Dispose ();
                LabelHotelPrice = null;
            }

            if (LabelInnerLimitedTimeOffer != null) {
                LabelInnerLimitedTimeOffer.Dispose ();
                LabelInnerLimitedTimeOffer = null;
            }

            if (LabelTotalForStay != null) {
                LabelTotalForStay.Dispose ();
                LabelTotalForStay = null;
            }

            if (LblLimitedTimeOffer != null) {
                LblLimitedTimeOffer.Dispose ();
                LblLimitedTimeOffer = null;
            }

            if (ViewBottomSeparater != null) {
                ViewBottomSeparater.Dispose ();
                ViewBottomSeparater = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }

            if (ViewTopSeparater != null) {
                ViewTopSeparater.Dispose ();
                ViewTopSeparater = null;
            }
        }
    }
}