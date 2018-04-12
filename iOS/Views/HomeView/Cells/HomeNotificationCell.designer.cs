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
    [Register ("HomeNotificationCell")]
    partial class HomeNotificationCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelGrayBelow { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelMainPopUp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelGrayBelow != null) {
                LabelGrayBelow.Dispose ();
                LabelGrayBelow = null;
            }

            if (LabelMainPopUp != null) {
                LabelMainPopUp.Dispose ();
                LabelMainPopUp = null;
            }
        }
    }
}