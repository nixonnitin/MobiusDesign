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
    [Register ("SearchFilterSwitchCell")]
    partial class SearchFilterSwitchCell
    {
        [Outlet]
        public UIKit.UILabel LabelFeatures { get; set; }


        [Outlet]
        public UIKit.UISwitch SwitchOnOFF { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelFeatures != null) {
                LabelFeatures.Dispose ();
                LabelFeatures = null;
            }

            if (SwitchOnOFF != null) {
                SwitchOnOFF.Dispose ();
                SwitchOnOFF = null;
            }
        }
    }
}