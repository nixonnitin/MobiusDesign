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
    [Register ("HomeCell15")]
    partial class HomeCell15
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintImageHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView LblLimitedOffer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintImageHeight != null) {
                ConstraintImageHeight.Dispose ();
                ConstraintImageHeight = null;
            }

            if (LblLimitedOffer != null) {
                LblLimitedOffer.Dispose ();
                LblLimitedOffer = null;
            }
        }
    }
}