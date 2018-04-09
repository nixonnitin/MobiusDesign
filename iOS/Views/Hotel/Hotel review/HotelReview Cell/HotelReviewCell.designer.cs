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
    [Register ("HotelReviewCell")]
    partial class HotelReviewCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewNext { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewProfile { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRating1 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRating2 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRating3 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRating4 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewRating5 { get; set; }


        [Outlet]
        public UIKit.UILabel LabelName { get; set; }


        [Outlet]
        public UIKit.UILabel LabelReview { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewNext != null) {
                ImageViewNext.Dispose ();
                ImageViewNext = null;
            }

            if (ImageViewProfile != null) {
                ImageViewProfile.Dispose ();
                ImageViewProfile = null;
            }

            if (ImageViewRating1 != null) {
                ImageViewRating1.Dispose ();
                ImageViewRating1 = null;
            }

            if (ImageViewRating2 != null) {
                ImageViewRating2.Dispose ();
                ImageViewRating2 = null;
            }

            if (ImageViewRating3 != null) {
                ImageViewRating3.Dispose ();
                ImageViewRating3 = null;
            }

            if (ImageViewRating4 != null) {
                ImageViewRating4.Dispose ();
                ImageViewRating4 = null;
            }

            if (ImageViewRating5 != null) {
                ImageViewRating5.Dispose ();
                ImageViewRating5 = null;
            }

            if (LabelName != null) {
                LabelName.Dispose ();
                LabelName = null;
            }

            if (LabelReview != null) {
                LabelReview.Dispose ();
                LabelReview = null;
            }
        }
    }
}