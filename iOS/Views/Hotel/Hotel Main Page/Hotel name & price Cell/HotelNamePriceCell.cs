using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelNamePriceCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelNamePriceCell");
        public static readonly UINib Nib;

        static HotelNamePriceCell()
        {
            Nib = UINib.FromName("HotelNamePriceCell", NSBundle.MainBundle);
        }

        protected HotelNamePriceCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
