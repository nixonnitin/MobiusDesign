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
    [Register ("CheckoutScanCardButtonCell")]
    partial class CheckoutScanCardButtonCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonScanCard { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageCamera { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelScanCard { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelUsingCamera { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonScanCard != null) {
                ButtonScanCard.Dispose ();
                ButtonScanCard = null;
            }

            if (ImageCamera != null) {
                ImageCamera.Dispose ();
                ImageCamera = null;
            }

            if (LabelScanCard != null) {
                LabelScanCard.Dispose ();
                LabelScanCard = null;
            }

            if (LabelUsingCamera != null) {
                LabelUsingCamera.Dispose ();
                LabelUsingCamera = null;
            }

            if (ViewContainer != null) {
                ViewContainer.Dispose ();
                ViewContainer = null;
            }
        }
    }
}