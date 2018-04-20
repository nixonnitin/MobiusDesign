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
    [Register ("PollPopupTableViewCell")]
    partial class PollPopupTableViewCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewTop { get; set; }


        [Outlet]
        public UIKit.UILabel LabelDescription { get; set; }


        [Outlet]
        public UIKit.UILabel LableTitle { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewTop != null) {
                ImageViewTop.Dispose ();
                ImageViewTop = null;
            }

            if (LabelDescription != null) {
                LabelDescription.Dispose ();
                LabelDescription = null;
            }

            if (LableTitle != null) {
                LableTitle.Dispose ();
                LableTitle = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}