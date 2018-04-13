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
    [Register ("CheckoutPaymentOptionButtons")]
    partial class CheckoutPaymentOptionButtons
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl SegmentPay { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SegmentPay != null) {
                SegmentPay.Dispose ();
                SegmentPay = null;
            }
        }
    }
}