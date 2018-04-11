using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelAmenitiesCollectionCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HotelAmenitiesCollectionCell");
        public static readonly UINib Nib;

        static HotelAmenitiesCollectionCell()
        {
            Nib = UINib.FromName("HotelAmenitiesCollectionCell", NSBundle.MainBundle);
        }

        protected HotelAmenitiesCollectionCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
