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
    [Register ("CheckoutPriceBreakdownCell")]
    partial class CheckoutPriceBreakdownCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel LabelAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel LabelDetail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView ViewSeperator { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelAmount != null) {
                LabelAmount.Dispose ();
                LabelAmount = null;
            }

            if (LabelDetail != null) {
                LabelDetail.Dispose ();
                LabelDetail = null;
            }

            if (ViewSeperator != null) {
                ViewSeperator.Dispose ();
                ViewSeperator = null;
            }
        }
    }
}