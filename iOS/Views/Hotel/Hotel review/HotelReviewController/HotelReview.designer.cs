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
    [Register ("HotelReview")]
    partial class HotelReview
    {
        [Outlet]
        public UIKit.UITableView TableViewHotelReview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewHotelReview != null) {
                TableViewHotelReview.Dispose ();
                TableViewHotelReview = null;
            }
        }
    }
}