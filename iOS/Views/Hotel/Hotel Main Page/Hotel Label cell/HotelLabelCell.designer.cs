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
    [Register ("HotelLabelCell")]
    partial class HotelLabelCell
    {
        [Outlet]
        public UIKit.UILabel LabelText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelText != null) {
                LabelText.Dispose ();
                LabelText = null;
            }
        }
    }
}