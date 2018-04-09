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
    [Register ("MyReservationsTableViewCell")]
    partial class MyReservationsTableViewCell
    {
        [Outlet]
        public UIKit.UIButton ButtonBookAgain { get; private set; }

        [Outlet]
        public UIKit.NSLayoutConstraint ImageViewHeightConstraint { get; private set; }

        [Outlet]
        public UIKit.UIImageView ImageViewRoomSmall { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelCheckInOut { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelSelectedDate { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelTotalPrice { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelTotalStay { get; private set; }

        [Outlet]
        public UIKit.UIView MainViewCell { get; private set; }

        [Outlet]
        public UIKit.NSLayoutConstraint MainViewCellHeightConstraint { get; private set; }

        [Outlet]
        public UIKit.UIView ViewCheckInOut { get; private set; }

        [Outlet]
        public UIKit.UIView ViewPrice { get; private set; }

        [Outlet]
        public UIKit.UIView ViewReservationSummary { get; set; }

        [Outlet]
        public UIKit.UIView ViewSelectedDate { get; private set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonBookAgain != null) {
                ButtonBookAgain.Dispose ();
                ButtonBookAgain = null;
            }

            if (ImageViewHeightConstraint != null) {
                ImageViewHeightConstraint.Dispose ();
                ImageViewHeightConstraint = null;
            }

            if (ImageViewRoomSmall != null) {
                ImageViewRoomSmall.Dispose ();
                ImageViewRoomSmall = null;
            }

            if (LabelCheckInOut != null) {
                LabelCheckInOut.Dispose ();
                LabelCheckInOut = null;
            }

            if (LabelSelectedDate != null) {
                LabelSelectedDate.Dispose ();
                LabelSelectedDate = null;
            }

            if (LabelTotalPrice != null) {
                LabelTotalPrice.Dispose ();
                LabelTotalPrice = null;
            }

            if (LabelTotalStay != null) {
                LabelTotalStay.Dispose ();
                LabelTotalStay = null;
            }

            if (MainViewCell != null) {
                MainViewCell.Dispose ();
                MainViewCell = null;
            }

            if (MainViewCellHeightConstraint != null) {
                MainViewCellHeightConstraint.Dispose ();
                MainViewCellHeightConstraint = null;
            }

            if (ViewCheckInOut != null) {
                ViewCheckInOut.Dispose ();
                ViewCheckInOut = null;
            }

            if (ViewPrice != null) {
                ViewPrice.Dispose ();
                ViewPrice = null;
            }

            if (ViewReservationSummary != null) {
                ViewReservationSummary.Dispose ();
                ViewReservationSummary = null;
            }

            if (ViewSelectedDate != null) {
                ViewSelectedDate.Dispose ();
                ViewSelectedDate = null;
            }
        }
    }
}