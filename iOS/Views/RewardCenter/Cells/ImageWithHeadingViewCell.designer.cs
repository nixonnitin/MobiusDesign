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
    [Register ("ImageWithHeadingViewCell")]
    partial class ImageWithHeadingViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageReward { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelHeadingReward { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageReward != null) {
                ImageReward.Dispose ();
                ImageReward = null;
            }

            if (LabelHeadingReward != null) {
                LabelHeadingReward.Dispose ();
                LabelHeadingReward = null;
            }
        }
    }
}