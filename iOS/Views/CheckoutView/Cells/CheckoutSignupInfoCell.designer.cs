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
    [Register ("CheckoutSignupInfoCell")]
    partial class CheckoutSignupInfoCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint ConstraintViewHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewInfoContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintViewHeight != null) {
                ConstraintViewHeight.Dispose ();
                ConstraintViewHeight = null;
            }

            if (LabelInfo != null) {
                LabelInfo.Dispose ();
                LabelInfo = null;
            }

            if (ViewInfoContainer != null) {
                ViewInfoContainer.Dispose ();
                ViewInfoContainer = null;
            }
        }
    }
}