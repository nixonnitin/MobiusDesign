// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Mobius.iOS.Views
{
    [Register ("BookSearch")]
    partial class BookSearch
    {
        [Outlet]
        public UIKit.UITableView tblMenu { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (tblMenu != null) {
                tblMenu.Dispose ();
                tblMenu = null;
            }
        }
    }
}