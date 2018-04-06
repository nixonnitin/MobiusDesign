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
    [Register ("HomeCell10")]
    partial class HomeCell10
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintSelectedViewWidth { get; private set; }


        [Outlet]
        public UIKit.UILabel LabelPointsDetail { get; private set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintSelectedViewWidth != null) {
                ConstraintSelectedViewWidth.Dispose ();
                ConstraintSelectedViewWidth = null;
            }

            if (LabelPointsDetail != null) {
                LabelPointsDetail.Dispose ();
                LabelPointsDetail = null;
            }
        }
    }
}