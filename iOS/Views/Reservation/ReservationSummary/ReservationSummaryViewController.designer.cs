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
    [Register ("ReservationSummaryViewController")]
    partial class ReservationSummaryViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewReservationSummary { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewReservationSummary != null) {
                TableViewReservationSummary.Dispose ();
                TableViewReservationSummary = null;
            }
        }
    }
}