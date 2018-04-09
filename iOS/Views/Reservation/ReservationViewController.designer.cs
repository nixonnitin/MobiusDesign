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
    [Register ("ReservationViewController")]
    partial class ReservationViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonConfirmUpdates { get; set; }


        [Outlet]
        public UIKit.UITableView TableViewReservation { get; private set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonConfirmUpdates != null) {
                ButtonConfirmUpdates.Dispose ();
                ButtonConfirmUpdates = null;
            }

            if (TableViewReservation != null) {
                TableViewReservation.Dispose ();
                TableViewReservation = null;
            }
        }
    }
}