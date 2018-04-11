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
    [Register ("CheckoutSingleInputTextCell")]
    partial class CheckoutSingleInputTextCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIImageView ImageInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UITextField TextInput { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView ViewInputContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageInput != null) {
                ImageInput.Dispose ();
                ImageInput = null;
            }

            if (TextInput != null) {
                TextInput.Dispose ();
                TextInput = null;
            }

            if (ViewInputContainer != null) {
                ViewInputContainer.Dispose ();
                ViewInputContainer = null;
            }
        }
    }
}