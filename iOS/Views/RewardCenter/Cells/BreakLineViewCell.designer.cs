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
    [Register ("BreakLineViewCell")]
    partial class BreakLineViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl SegmentControlTab { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView UiViewBreakline { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (SegmentControlTab != null) {
                SegmentControlTab.Dispose ();
                SegmentControlTab = null;
            }

            if (UiViewBreakline != null) {
                UiViewBreakline.Dispose ();
                UiViewBreakline = null;
            }
        }
    }
}