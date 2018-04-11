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
    [Register ("HotelLowestPriceWithDataCell")]
    partial class HotelLowestPriceWithDataCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewCal { get; set; }

        [Outlet]
        public UIKit.UIImageView ImageViewDropDown { get; set; }

        [Outlet]
        public UIKit.UILabel LabelDate { get; set; }

        [Outlet]
        public UIKit.UILabel LabelLowestPRice { get; set; }

        [Outlet]
        public UIKit.UILabel LabelPRice { get; set; }

        [Outlet]
        public UIKit.UILabel LabelViewDate { get; set; }

        [Outlet]
        public UIKit.UIView ViewDate { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewCal != null) {
                ImageViewCal.Dispose ();
                ImageViewCal = null;
            }

            if (ImageViewDropDown != null) {
                ImageViewDropDown.Dispose ();
                ImageViewDropDown = null;
            }

            if (LabelDate != null) {
                LabelDate.Dispose ();
                LabelDate = null;
            }

            if (LabelLowestPRice != null) {
                LabelLowestPRice.Dispose ();
                LabelLowestPRice = null;
            }

            if (LabelPRice != null) {
                LabelPRice.Dispose ();
                LabelPRice = null;
            }

            if (LabelViewDate != null) {
                LabelViewDate.Dispose ();
                LabelViewDate = null;
            }

            if (ViewDate != null) {
                ViewDate.Dispose ();
                ViewDate = null;
            }
        }
    }
}