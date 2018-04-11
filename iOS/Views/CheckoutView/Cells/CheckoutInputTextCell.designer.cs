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
    [Register ("CheckoutInputTextCell")]
    partial class CheckoutInputTextCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint ConstraintSubInputTrail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.NSLayoutConstraint ConstraintSubInputWidth { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageInputView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextSubInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewInputContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewSubInputContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintSubInputTrail != null) {
                ConstraintSubInputTrail.Dispose ();
                ConstraintSubInputTrail = null;
            }

            if (ConstraintSubInputWidth != null) {
                ConstraintSubInputWidth.Dispose ();
                ConstraintSubInputWidth = null;
            }

            if (ImageInputView != null) {
                ImageInputView.Dispose ();
                ImageInputView = null;
            }

            if (TextInput != null) {
                TextInput.Dispose ();
                TextInput = null;
            }

            if (TextSubInput != null) {
                TextSubInput.Dispose ();
                TextSubInput = null;
            }

            if (ViewInputContainer != null) {
                ViewInputContainer.Dispose ();
                ViewInputContainer = null;
            }

            if (ViewSubInputContainer != null) {
                ViewSubInputContainer.Dispose ();
                ViewSubInputContainer = null;
            }
        }
    }
}