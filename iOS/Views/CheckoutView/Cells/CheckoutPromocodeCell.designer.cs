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
    [Register ("CheckoutPromocodeCell")]
    partial class CheckoutPromocodeCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonCheckbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImagePromocode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPromocode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextPromocode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewPromocodeContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonCheckbox != null) {
                ButtonCheckbox.Dispose ();
                ButtonCheckbox = null;
            }

            if (ImagePromocode != null) {
                ImagePromocode.Dispose ();
                ImagePromocode = null;
            }

            if (LabelPromocode != null) {
                LabelPromocode.Dispose ();
                LabelPromocode = null;
            }

            if (TextPromocode != null) {
                TextPromocode.Dispose ();
                TextPromocode = null;
            }

            if (ViewPromocodeContainer != null) {
                ViewPromocodeContainer.Dispose ();
                ViewPromocodeContainer = null;
            }
        }
    }
}