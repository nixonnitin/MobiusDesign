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
    [Register ("HotelQuickBookViewController")]
    partial class HotelQuickBookViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewHotelQuickBook { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewHotelQuickBook != null) {
                TableViewHotelQuickBook.Dispose ();
                TableViewHotelQuickBook = null;
            }
        }
    }
}