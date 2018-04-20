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
    [Register ("PointsViewController")]
    partial class PointsViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewPoints { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewPoints != null) {
                TableViewPoints.Dispose ();
                TableViewPoints = null;
            }
        }
    }
}