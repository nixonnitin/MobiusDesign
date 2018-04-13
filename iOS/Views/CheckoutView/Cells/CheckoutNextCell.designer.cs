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
    [Register ("CheckoutNextCell")]
    partial class CheckoutNextCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonNext { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonPriceBreakdown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageBlueArrowDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelInfo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelOr { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTotalForStay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelTotalPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewInfoContainer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewInfoLabelContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonNext != null) {
                ButtonNext.Dispose ();
                ButtonNext = null;
            }

            if (ButtonPriceBreakdown != null) {
                ButtonPriceBreakdown.Dispose ();
                ButtonPriceBreakdown = null;
            }

            if (ImageBlueArrowDown != null) {
                ImageBlueArrowDown.Dispose ();
                ImageBlueArrowDown = null;
            }

            if (LabelInfo != null) {
                LabelInfo.Dispose ();
                LabelInfo = null;
            }

            if (LabelOr != null) {
                LabelOr.Dispose ();
                LabelOr = null;
            }

            if (LabelPoints != null) {
                LabelPoints.Dispose ();
                LabelPoints = null;
            }

            if (LabelPrice != null) {
                LabelPrice.Dispose ();
                LabelPrice = null;
            }

            if (LabelTotalForStay != null) {
                LabelTotalForStay.Dispose ();
                LabelTotalForStay = null;
            }

            if (LabelTotalPoints != null) {
                LabelTotalPoints.Dispose ();
                LabelTotalPoints = null;
            }

            if (ViewInfoContainer != null) {
                ViewInfoContainer.Dispose ();
                ViewInfoContainer = null;
            }

            if (ViewInfoLabelContainer != null) {
                ViewInfoLabelContainer.Dispose ();
                ViewInfoLabelContainer = null;
            }
        }
    }
}