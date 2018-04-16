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
    [Register ("RewardDescriptionViewCell")]
    partial class RewardDescriptionViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelDescriptionHeading { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewMainForDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelDescription != null) {
                LabelDescription.Dispose ();
                LabelDescription = null;
            }

            if (LabelDescriptionHeading != null) {
                LabelDescriptionHeading.Dispose ();
                LabelDescriptionHeading = null;
            }

            if (ViewMainForDescription != null) {
                ViewMainForDescription.Dispose ();
                ViewMainForDescription = null;
            }
        }
    }
}