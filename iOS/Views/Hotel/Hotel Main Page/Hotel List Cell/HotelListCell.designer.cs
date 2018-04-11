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
    [Register ("HotelListCell")]
    partial class HotelListCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewNext { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRoom { get; set; }


        [Outlet]
        public UIKit.UILabel LabelPricePerNight { get; set; }


        [Outlet]
        public UIKit.UILabel LabelRoomType { get; set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewNext != null) {
                ImageViewNext.Dispose ();
                ImageViewNext = null;
            }

            if (ImageViewRoom != null) {
                ImageViewRoom.Dispose ();
                ImageViewRoom = null;
            }

            if (LabelPricePerNight != null) {
                LabelPricePerNight.Dispose ();
                LabelPricePerNight = null;
            }

            if (LabelRoomType != null) {
                LabelRoomType.Dispose ();
                LabelRoomType = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}