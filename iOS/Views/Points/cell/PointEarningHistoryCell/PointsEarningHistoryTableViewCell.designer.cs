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
    [Register ("PointsEarningHistoryTableViewCell")]
    partial class PointsEarningHistoryTableViewCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewStar { get; set; }


        [Outlet]
        public UIKit.UILabel LabelDescription { get; set; }


        [Outlet]
        public UIKit.UILabel LabelTitle { get; set; }


        [Outlet]
        public UIKit.UIView ViewBackgroundLine { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewTopLine { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewStar != null) {
                ImageViewStar.Dispose ();
                ImageViewStar = null;
            }

            if (LabelDescription != null) {
                LabelDescription.Dispose ();
                LabelDescription = null;
            }

            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }

            if (ViewBackgroundLine != null) {
                ViewBackgroundLine.Dispose ();
                ViewBackgroundLine = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }

            if (ViewTopLine != null) {
                ViewTopLine.Dispose ();
                ViewTopLine = null;
            }
        }
    }
}