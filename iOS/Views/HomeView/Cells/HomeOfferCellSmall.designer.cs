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
    [Register ("HomeOfferCellSmall")]
    partial class HomeOfferCellSmall
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintOfferHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LimitedOfferLayout { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView OfferImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView offerLayout { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintOfferHeight != null) {
                ConstraintOfferHeight.Dispose ();
                ConstraintOfferHeight = null;
            }

            if (LimitedOfferLayout != null) {
                LimitedOfferLayout.Dispose ();
                LimitedOfferLayout = null;
            }

            if (OfferImage != null) {
                OfferImage.Dispose ();
                OfferImage = null;
            }

            if (offerLayout != null) {
                offerLayout.Dispose ();
                offerLayout = null;
            }
        }
    }
}