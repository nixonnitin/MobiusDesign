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
    [Register ("HomeCell3")]
    partial class HomeCell3
    {
        [Outlet]
        public UIKit.UILabel LabelText { get; set; }


        [Outlet]
        public UIKit.UILabel LabelTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
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