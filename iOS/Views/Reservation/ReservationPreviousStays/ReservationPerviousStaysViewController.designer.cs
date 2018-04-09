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
    [Register ("ReservationPerviousStaysViewController")]
    partial class ReservationPerviousStaysViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewPreviousStaysList { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewPreviousStaysList != null) {
                TableViewPreviousStaysList.Dispose ();
                TableViewPreviousStaysList = null;
            }
        }
    }
}