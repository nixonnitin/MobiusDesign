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
    [Register ("RewardsTableViewCell")]
    partial class RewardsTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHeadRowDate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHeadRowRewardName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHeadRowStatus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRewardNameValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRowDateValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelStatusValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewBreakLine { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelHeadRowDate != null) {
                LabelHeadRowDate.Dispose ();
                LabelHeadRowDate = null;
            }

            if (LabelHeadRowRewardName != null) {
                LabelHeadRowRewardName.Dispose ();
                LabelHeadRowRewardName = null;
            }

            if (LabelHeadRowStatus != null) {
                LabelHeadRowStatus.Dispose ();
                LabelHeadRowStatus = null;
            }

            if (LabelRewardNameValue != null) {
                LabelRewardNameValue.Dispose ();
                LabelRewardNameValue = null;
            }

            if (LabelRowDateValue != null) {
                LabelRowDateValue.Dispose ();
                LabelRowDateValue = null;
            }

            if (LabelStatusValue != null) {
                LabelStatusValue.Dispose ();
                LabelStatusValue = null;
            }

            if (ViewBreakLine != null) {
                ViewBreakLine.Dispose ();
                ViewBreakLine = null;
            }
        }
    }
}