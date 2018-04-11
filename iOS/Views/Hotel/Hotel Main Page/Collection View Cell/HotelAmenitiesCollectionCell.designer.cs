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
    [Register ("HotelAmenitiesCollectionCell")]
    partial class HotelAmenitiesCollectionCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewAmenities { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAmenities { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewAmenities != null) {
                ImageViewAmenities.Dispose ();
                ImageViewAmenities = null;
            }

            if (LabelAmenities != null) {
                LabelAmenities.Dispose ();
                LabelAmenities = null;
            }
        }
    }
}