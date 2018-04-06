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
    [Register ("PreferncesViewController")]
    partial class PreferncesViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewPreferences { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewPreferences != null) {
                TableViewPreferences.Dispose ();
                TableViewPreferences = null;
            }
        }
    }
}