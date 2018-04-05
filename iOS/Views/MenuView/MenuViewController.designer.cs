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
    [Register ("MenuViewController")]
    partial class MenuViewController
    {
        [Outlet]
        UIKit.UIButton btnCheckAvailability { get; set; }


        [Outlet]
        UIKit.UITableView tblMenu { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCheckAvailability != null) {
                btnCheckAvailability.Dispose ();
                btnCheckAvailability = null;
            }

            if (tblMenu != null) {
                tblMenu.Dispose ();
                tblMenu = null;
            }
        }
    }
}