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
    [Register ("HotelNamePriceCell")]
    partial class HotelNamePriceCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewOwl { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageVIewRating1 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageVIewRating2 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageVIewRating3 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageVIewRating4 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageVIewRating5 { get; set; }


        [Outlet]
        public UIKit.UILabel LabelHotelCity { get; set; }


        [Outlet]
        public UIKit.UILabel LabelHotelName { get; set; }


        [Outlet]
        public UIKit.UILabel LabelHotelPRice { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewOwl != null) {
                ImageViewOwl.Dispose ();
                ImageViewOwl = null;
            }

            if (ImageVIewRating1 != null) {
                ImageVIewRating1.Dispose ();
                ImageVIewRating1 = null;
            }

            if (ImageVIewRating2 != null) {
                ImageVIewRating2.Dispose ();
                ImageVIewRating2 = null;
            }

            if (ImageVIewRating3 != null) {
                ImageVIewRating3.Dispose ();
                ImageVIewRating3 = null;
            }

            if (ImageVIewRating4 != null) {
                ImageVIewRating4.Dispose ();
                ImageVIewRating4 = null;
            }

            if (ImageVIewRating5 != null) {
                ImageVIewRating5.Dispose ();
                ImageVIewRating5 = null;
            }

            if (LabelHotelCity != null) {
                LabelHotelCity.Dispose ();
                LabelHotelCity = null;
            }

            if (LabelHotelName != null) {
                LabelHotelName.Dispose ();
                LabelHotelName = null;
            }

            if (LabelHotelPRice != null) {
                LabelHotelPRice.Dispose ();
                LabelHotelPRice = null;
            }
        }
    }
}