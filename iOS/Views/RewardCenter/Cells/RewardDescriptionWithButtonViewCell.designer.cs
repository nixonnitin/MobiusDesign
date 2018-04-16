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
    [Register ("RewardDescriptionWithButtonViewCell")]
    partial class RewardDescriptionWithButtonViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonBuyPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRewardDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewMainDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewSeperatorBreak { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonBuyPoints != null) {
                ButtonBuyPoints.Dispose ();
                ButtonBuyPoints = null;
            }

            if (LabelRewardDescription != null) {
                LabelRewardDescription.Dispose ();
                LabelRewardDescription = null;
            }

            if (ViewMainDescription != null) {
                ViewMainDescription.Dispose ();
                ViewMainDescription = null;
            }

            if (ViewSeperatorBreak != null) {
                ViewSeperatorBreak.Dispose ();
                ViewSeperatorBreak = null;
            }
        }
    }
}