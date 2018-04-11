using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelDateGuestCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelDateGuestCell");
        public static readonly UINib Nib;

        static HotelDateGuestCell()
        {
            Nib = UINib.FromName("HotelDateGuestCell", NSBundle.MainBundle);
        }

        protected HotelDateGuestCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
