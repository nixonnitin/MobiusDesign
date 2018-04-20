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
    [Register ("PointsTwoLabelTableViewCell")]
    partial class PointsTwoLabelTableViewCell
    {
        [Outlet]
        public UIKit.UILabel LabelPoints { get; set; }


        [Outlet]
        public UIKit.UILabel LabelYourLedger { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelPoints != null) {
                LabelPoints.Dispose ();
                LabelPoints = null;
            }

            if (LabelYourLedger != null) {
                LabelYourLedger.Dispose ();
                LabelYourLedger = null;
            }
        }
    }
}