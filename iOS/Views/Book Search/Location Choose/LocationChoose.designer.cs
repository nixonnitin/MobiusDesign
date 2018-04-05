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
    [Register ("LocationChoose")]
    partial class LocationChoose
    {
        [Outlet]
        public UIKit.UITableView TableViewLocation { get; set; }


        [Outlet]
        public UIKit.UITextField TextFieldLocation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewLocation != null) {
                TableViewLocation.Dispose ();
                TableViewLocation = null;
            }

            if (TextFieldLocation != null) {
                TextFieldLocation.Dispose ();
                TextFieldLocation = null;
            }
        }
    }
}