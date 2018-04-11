// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
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
            if (LabelLowestPRice != null) {
                LabelLowestPRice.Dispose ();
                LabelLowestPRice = null;
            }

            if (LabelPRice != null) {
                LabelPRice.Dispose ();
                LabelPRice = null;
            }

            if (LabelDate != null) {
                LabelDate.Dispose ();
                LabelDate = null;
            }

            if (ViewDate != null) {
                ViewDate.Dispose ();
                ViewDate = null;
            }

            if (ImageViewCal != null) {
                ImageViewCal.Dispose ();
                ImageViewCal = null;
            }

            if (ImageViewDropDown != null) {
                ImageViewDropDown.Dispose ();
                ImageViewDropDown = null;
            }

            if (LabelViewDate != null) {
                LabelViewDate.Dispose ();
                LabelViewDate = null;
            }
        }
    }
}
