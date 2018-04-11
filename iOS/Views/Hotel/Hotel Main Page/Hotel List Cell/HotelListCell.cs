using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelListCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelListCell");
        public static readonly UINib Nib;

        static HotelListCell()
        {
            Nib = UINib.FromName("HotelListCell", NSBundle.MainBundle);
        }

        protected HotelListCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
