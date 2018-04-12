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
    [Register ("HomeRateCell")]
    partial class HomeRateCell
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintButtonCheckinHeight { get; set; }

        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintLabelAdvancedPurchaseHeight { get; set; }

        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintOfferHeight { get; private set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonHotelImageEdit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CheckInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint ConstraintHotelImageHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint ConstraintHotelNameTop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageHotelRoomrate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelAdvabcePurchaseRate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHotelName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHotelPlace { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LblLimitedTimeOffer { get; set; }

        [Action ("CheckInButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CheckInButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ButtonHotelImageEdit != null) {
                ButtonHotelImageEdit.Dispose ();
                ButtonHotelImageEdit = null;
            }

            if (CheckInButton != null) {
                CheckInButton.Dispose ();
                CheckInButton = null;
            }

            if (ConstraintButtonCheckinHeight != null) {
                ConstraintButtonCheckinHeight.Dispose ();
                ConstraintButtonCheckinHeight = null;
            }

            if (ConstraintHotelImageHeight != null) {
                ConstraintHotelImageHeight.Dispose ();
                ConstraintHotelImageHeight = null;
            }

            if (ConstraintHotelNameTop != null) {
                ConstraintHotelNameTop.Dispose ();
                ConstraintHotelNameTop = null;
            }

            if (ConstraintLabelAdvancedPurchaseHeight != null) {
                ConstraintLabelAdvancedPurchaseHeight.Dispose ();
                ConstraintLabelAdvancedPurchaseHeight = null;
            }

            if (ConstraintOfferHeight != null) {
                ConstraintOfferHeight.Dispose ();
                ConstraintOfferHeight = null;
            }

            if (ImageHotelRoomrate != null) {
                ImageHotelRoomrate.Dispose ();
                ImageHotelRoomrate = null;
            }

            if (LabelAdvabcePurchaseRate != null) {
                LabelAdvabcePurchaseRate.Dispose ();
                LabelAdvabcePurchaseRate = null;
            }

            if (LabelHotelName != null) {
                LabelHotelName.Dispose ();
                LabelHotelName = null;
            }

            if (LabelHotelPlace != null) {
                LabelHotelPlace.Dispose ();
                LabelHotelPlace = null;
            }

            if (LblLimitedTimeOffer != null) {
                LblLimitedTimeOffer.Dispose ();
                LblLimitedTimeOffer = null;
            }
        }
    }
}