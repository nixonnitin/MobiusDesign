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
    [Register ("CheckoutCardExpireCell")]
    partial class CheckoutCardExpireCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelCVV { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelExpire { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextCVV { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextMM { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextYY { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewCVVContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewMMContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewYYContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelCVV != null) {
                LabelCVV.Dispose ();
                LabelCVV = null;
            }

            if (LabelExpire != null) {
                LabelExpire.Dispose ();
                LabelExpire = null;
            }

            if (TextCVV != null) {
                TextCVV.Dispose ();
                TextCVV = null;
            }

            if (TextMM != null) {
                TextMM.Dispose ();
                TextMM = null;
            }

            if (TextYY != null) {
                TextYY.Dispose ();
                TextYY = null;
            }

            if (ViewCVVContainer != null) {
                ViewCVVContainer.Dispose ();
                ViewCVVContainer = null;
            }

            if (ViewMMContainer != null) {
                ViewMMContainer.Dispose ();
                ViewMMContainer = null;
            }

            if (ViewYYContainer != null) {
                ViewYYContainer.Dispose ();
                ViewYYContainer = null;
            }
        }
    }
}