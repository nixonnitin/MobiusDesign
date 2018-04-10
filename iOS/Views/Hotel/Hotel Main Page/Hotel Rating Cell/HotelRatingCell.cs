using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelRatingCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelRatingCell");
        public static readonly UINib Nib;

        static HotelRatingCell()
        {
            Nib = UINib.FromName("HotelRatingCell", NSBundle.MainBundle);
        }

        protected HotelRatingCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
