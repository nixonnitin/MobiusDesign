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
    [Register ("LocationChooseCell")]
    partial class LocationChooseCell
    {
        [Outlet]
        public UIKit.UILabel LabelLocation { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelLocation != null) {
                LabelLocation.Dispose ();
                LabelLocation = null;
            }
        }
    }
}