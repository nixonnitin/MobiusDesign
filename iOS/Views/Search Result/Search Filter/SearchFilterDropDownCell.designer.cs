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
    [Register ("SearchFilterDropDownCell")]
    partial class SearchFilterDropDownCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewDropDown { get; set; }


        [Outlet]
        public UIKit.UILabel LabelData { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewDropDown != null) {
                ImageViewDropDown.Dispose ();
                ImageViewDropDown = null;
            }

            if (LabelData != null) {
                LabelData.Dispose ();
                LabelData = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}