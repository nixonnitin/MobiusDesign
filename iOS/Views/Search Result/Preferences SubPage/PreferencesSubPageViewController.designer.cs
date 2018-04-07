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
    [Register ("PreferencesSubPageViewController")]
    partial class PreferencesSubPageViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewPreferencesSubPage { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewPreferencesSubPage != null) {
                TableViewPreferencesSubPage.Dispose ();
                TableViewPreferencesSubPage = null;
            }
        }
    }
}