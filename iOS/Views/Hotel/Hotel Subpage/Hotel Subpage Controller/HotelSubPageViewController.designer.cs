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
    [Register ("HotelSubPageViewController")]
    partial class HotelSubPageViewController
    {
        [Outlet]
        UIKit.UITableView TableViewHotelSubPage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewHotelSubPage != null) {
                TableViewHotelSubPage.Dispose ();
                TableViewHotelSubPage = null;
            }
        }
    }
}