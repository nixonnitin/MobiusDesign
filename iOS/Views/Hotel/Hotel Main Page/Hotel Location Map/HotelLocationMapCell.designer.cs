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
    [Register ("HotelLocationMapCell")]
    partial class HotelLocationMapCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewLocation { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewLocationView { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAddress { get; set; }


        [Outlet]
        public UIKit.UILabel LabelLocation { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewLocation != null) {
                ImageViewLocation.Dispose ();
                ImageViewLocation = null;
            }

            if (ImageViewLocationView != null) {
                ImageViewLocationView.Dispose ();
                ImageViewLocationView = null;
            }

            if (LabelAddress != null) {
                LabelAddress.Dispose ();
                LabelAddress = null;
            }

            if (LabelLocation != null) {
                LabelLocation.Dispose ();
                LabelLocation = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}