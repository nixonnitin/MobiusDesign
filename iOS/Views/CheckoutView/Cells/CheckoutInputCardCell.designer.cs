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
    [Register ("CheckoutInputCardCell")]
    partial class CheckoutInputCardCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelError { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewErrorContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewInputContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageInput != null) {
                ImageInput.Dispose ();
                ImageInput = null;
            }

            if (LabelError != null) {
                LabelError.Dispose ();
                LabelError = null;
            }

            if (TextInput != null) {
                TextInput.Dispose ();
                TextInput = null;
            }

            if (ViewErrorContainer != null) {
                ViewErrorContainer.Dispose ();
                ViewErrorContainer = null;
            }

            if (ViewInputContainer != null) {
                ViewInputContainer.Dispose ();
                ViewInputContainer = null;
            }
        }
    }
}