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
    [Register ("HotelQuickBookImageCell")]
    partial class HotelQuickBookImageCell
    {
        [Outlet]
        public UIKit.UIButton ButtonLeft { get; private set; }


        [Outlet]
        public UIKit.UIButton ButtonRight { get; private set; }


        [Outlet]
        public UIKit.UIImageView ImageViewHotek { get; private set; }


        [Outlet]
        public UIKit.UIPageControl PageController { get; private set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonLeft != null) {
                ButtonLeft.Dispose ();
                ButtonLeft = null;
            }

            if (ButtonRight != null) {
                ButtonRight.Dispose ();
                ButtonRight = null;
            }

            if (ImageViewHotek != null) {
                ImageViewHotek.Dispose ();
                ImageViewHotek = null;
            }

            if (PageController != null) {
                PageController.Dispose ();
                PageController = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}