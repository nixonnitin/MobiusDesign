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
    [Register ("EditReservationChangeDatesAmountConfirmationViewController")]
    partial class EditReservationChangeDatesAmountConfirmationViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonConfirmChangeDates { get; set; }


        [Outlet]
        public UIKit.UIView EditReservationChangeDatesPopUp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonConfirmChangeDates != null) {
                ButtonConfirmChangeDates.Dispose ();
                ButtonConfirmChangeDates = null;
            }

            if (EditReservationChangeDatesPopUp != null) {
                EditReservationChangeDatesPopUp.Dispose ();
                EditReservationChangeDatesPopUp = null;
            }
        }
    }
}