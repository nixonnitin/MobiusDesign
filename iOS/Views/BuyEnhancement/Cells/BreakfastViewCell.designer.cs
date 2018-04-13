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
    [Register ("BreakfastViewCell")]
    partial class BreakfastViewCell
    {
    
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonDollar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtonPoints { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageBreakfast { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelBreakfast { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelBreakFastDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonDollar != null) {
                ButtonDollar.Dispose ();
                ButtonDollar = null;
            }

            if (ButtonPoints != null) {
                ButtonPoints.Dispose ();
                ButtonPoints = null;
            }

            if (ImageBreakfast != null) {
                ImageBreakfast.Dispose ();
                ImageBreakfast = null;
            }

            if (LabelBreakfast != null) {
                LabelBreakfast.Dispose ();
                LabelBreakfast = null;
            }

            if (LabelBreakFastDescription != null) {
                LabelBreakFastDescription.Dispose ();
                LabelBreakFastDescription = null;
            }
        }
    }
}