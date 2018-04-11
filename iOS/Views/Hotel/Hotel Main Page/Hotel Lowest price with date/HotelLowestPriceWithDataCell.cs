using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelLowestPriceWithDataCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelLowestPriceWithDataCell");
        public static readonly UINib Nib;

        static HotelLowestPriceWithDataCell()
        {
            Nib = UINib.FromName("HotelLowestPriceWithDataCell", NSBundle.MainBundle);
        }

        protected HotelLowestPriceWithDataCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
