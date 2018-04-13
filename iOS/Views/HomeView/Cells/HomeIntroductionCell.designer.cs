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
    [Register ("HomeIntroductionCell")]
    partial class HomeIntroductionCell
    {
        [Outlet]
        public UIKit.UILabel LabelText { get; set; }


        [Outlet]
        public UIKit.UILabel LabelTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageBackground { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageBackground != null) {
                ImageBackground.Dispose ();
                ImageBackground = null;
            }

            if (LabelText != null) {
                LabelText.Dispose ();
                LabelText = null;
            }

            if (LabelTitle != null) {
                LabelTitle.Dispose ();
                LabelTitle = null;
            }
        }
    }
}