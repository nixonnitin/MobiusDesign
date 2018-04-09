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
    [Register ("CancelReservationViewController")]
    partial class CancelReservationViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonNo { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonYes { get; set; }


        [Outlet]
        public UIKit.UIView ViewCancelReservation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonNo != null) {
                ButtonNo.Dispose ();
                ButtonNo = null;
            }

            if (ButtonYes != null) {
                ButtonYes.Dispose ();
                ButtonYes = null;
            }

            if (ViewCancelReservation != null) {
                ViewCancelReservation.Dispose ();
                ViewCancelReservation = null;
            }
        }
    }
}