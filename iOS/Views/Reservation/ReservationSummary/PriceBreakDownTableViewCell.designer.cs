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
    [Register ("PriceBreakDownTableViewCell")]
    partial class PriceBreakDownTableViewCell
    {
        [Outlet]
        public UIKit.UIButton ButtonCancelReservation { get; set; }


        [Outlet]
        public UIKit.UIView ViewPriceBreakDown { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonCancelReservation != null) {
                ButtonCancelReservation.Dispose ();
                ButtonCancelReservation = null;
            }

            if (ViewPriceBreakDown != null) {
                ViewPriceBreakDown.Dispose ();
                ViewPriceBreakDown = null;
            }
        }
    }
}