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
    [Register ("OfferPageOfferCell")]
    partial class OfferPageOfferCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageOffer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelBookingInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelOffer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageOffer != null) {
                ImageOffer.Dispose ();
                ImageOffer = null;
            }

            if (LabelBookingInfo != null) {
                LabelBookingInfo.Dispose ();
                LabelBookingInfo = null;
            }

            if (LabelOffer != null) {
                LabelOffer.Dispose ();
                LabelOffer = null;
            }
        }
    }
}