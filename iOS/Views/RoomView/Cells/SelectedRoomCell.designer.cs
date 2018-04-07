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
    [Register ("SelectedRoomCell")]
    partial class SelectedRoomCell
    {
        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintImageSliderHeight { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintImageSliderHeight != null) {
                ConstraintImageSliderHeight.Dispose ();
                ConstraintImageSliderHeight = null;
            }
        }
    }
}