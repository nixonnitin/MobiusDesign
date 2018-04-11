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
    [Register ("HotelMoreCell")]
    partial class HotelMoreCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewFacility { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewNext { get; set; }


        [Outlet]
        public UIKit.UILabel LabelFacility { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewFacility != null) {
                ImageViewFacility.Dispose ();
                ImageViewFacility = null;
            }

            if (ImageViewNext != null) {
                ImageViewNext.Dispose ();
                ImageViewNext = null;
            }

            if (LabelFacility != null) {
                LabelFacility.Dispose ();
                LabelFacility = null;
            }
        }
    }
}