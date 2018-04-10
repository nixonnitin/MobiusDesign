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
    [Register ("HotelRatingCell")]
    partial class HotelRatingCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewNext { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewReviewer1 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewReviewer2 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewReviewer3 { get; set; }


        [Outlet]
        public UIKit.UILabel LabelNumberOfReviews { get; set; }


        [Outlet]
        public UIKit.UILabel LabelRating { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewNext != null) {
                ImageViewNext.Dispose ();
                ImageViewNext = null;
            }

            if (ImageViewReviewer1 != null) {
                ImageViewReviewer1.Dispose ();
                ImageViewReviewer1 = null;
            }

            if (ImageViewReviewer2 != null) {
                ImageViewReviewer2.Dispose ();
                ImageViewReviewer2 = null;
            }

            if (ImageViewReviewer3 != null) {
                ImageViewReviewer3.Dispose ();
                ImageViewReviewer3 = null;
            }

            if (LabelNumberOfReviews != null) {
                LabelNumberOfReviews.Dispose ();
                LabelNumberOfReviews = null;
            }

            if (LabelRating != null) {
                LabelRating.Dispose ();
                LabelRating = null;
            }
        }
    }
}