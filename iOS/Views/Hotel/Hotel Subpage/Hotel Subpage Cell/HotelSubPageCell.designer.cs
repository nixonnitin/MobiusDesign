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
    [Register ("HotelSubPageCell")]
    partial class HotelSubPageCell
    {
        [Outlet]
        public UIKit.UILabel LabelContent { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelContent != null) {
                LabelContent.Dispose ();
                LabelContent = null;
            }
        }
    }
}