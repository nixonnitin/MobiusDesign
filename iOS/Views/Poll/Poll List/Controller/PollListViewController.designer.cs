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
    [Register ("PollListViewController")]
    partial class PollListViewController
    {
        [Outlet]
        public UIKit.UITableView TableViewPollList { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (TableViewPollList != null) {
                TableViewPollList.Dispose ();
                TableViewPollList = null;
            }
        }
    }
}