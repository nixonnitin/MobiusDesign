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
    [Register ("SearchFilterResetApplyCell")]
    partial class SearchFilterResetApplyCell
    {
        [Outlet]
        public UIKit.UIButton ButtonApply { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonReset { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonApply != null) {
                ButtonApply.Dispose ();
                ButtonApply = null;
            }

            if (ButtonReset != null) {
                ButtonReset.Dispose ();
                ButtonReset = null;
            }
        }
    }
}