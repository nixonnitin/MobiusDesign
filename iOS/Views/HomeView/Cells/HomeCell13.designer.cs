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
    [Register ("HomeCell13")]
    partial class HomeCell13
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintButtonCheckinHeight { get; set; }

        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintLabelAdvancedPurchaseHeight { get; set; }

        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintOfferHeight { get; private set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CheckInButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LblLimitedTimeOffer { get; set; }

        [Action ("CheckInButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CheckInButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (CheckInButton != null) {
                CheckInButton.Dispose ();
                CheckInButton = null;
            }

            if (ConstraintButtonCheckinHeight != null) {
                ConstraintButtonCheckinHeight.Dispose ();
                ConstraintButtonCheckinHeight = null;
            }

            if (ConstraintLabelAdvancedPurchaseHeight != null) {
                ConstraintLabelAdvancedPurchaseHeight.Dispose ();
                ConstraintLabelAdvancedPurchaseHeight = null;
            }

            if (ConstraintOfferHeight != null) {
                ConstraintOfferHeight.Dispose ();
                ConstraintOfferHeight = null;
            }

            if (LblLimitedTimeOffer != null) {
                LblLimitedTimeOffer.Dispose ();
                LblLimitedTimeOffer = null;
            }
        }
    }
}