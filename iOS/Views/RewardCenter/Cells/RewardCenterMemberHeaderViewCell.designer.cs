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
    [Register ("RewardCenterMemberHeaderViewCell")]
    partial class RewardCenterMemberHeaderViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageMemeberHeader { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelMemberName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelMemberSince { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageMemeberHeader != null) {
                ImageMemeberHeader.Dispose ();
                ImageMemeberHeader = null;
            }

            if (LabelMemberName != null) {
                LabelMemberName.Dispose ();
                LabelMemberName = null;
            }

            if (LabelMemberSince != null) {
                LabelMemberSince.Dispose ();
                LabelMemberSince = null;
            }
        }
    }
}