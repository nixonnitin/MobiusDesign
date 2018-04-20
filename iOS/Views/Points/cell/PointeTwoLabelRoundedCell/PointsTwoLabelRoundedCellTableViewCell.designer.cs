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
    [Register ("PointsTwoLabelRoundedCellTableViewCell")]
    partial class PointsTwoLabelRoundedCellTableViewCell
    {
        [Outlet]
        public UIKit.UILabel LabelPointLedger { get; set; }


        [Outlet]
        public UIKit.UILabel LabelPoints { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelPointLedger != null) {
                LabelPointLedger.Dispose ();
                LabelPointLedger = null;
            }

            if (LabelPoints != null) {
                LabelPoints.Dispose ();
                LabelPoints = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}