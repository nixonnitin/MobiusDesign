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
    [Register ("TestViewController")]
    partial class TestViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView TableTest { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableTest != null) {
                TableTest.Dispose ();
                TableTest = null;
            }
        }
    }
}