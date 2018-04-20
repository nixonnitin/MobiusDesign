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
    [Register ("ConfirmationViewController")]
    partial class ConfirmationViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewConfirmation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewConfirmation != null) {
                TableViewConfirmation.Dispose ();
                TableViewConfirmation = null;
            }
        }
    }
}