using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelLocationMapCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelLocationMapCell");
        public static readonly UINib Nib;

        static HotelLocationMapCell()
        {
            Nib = UINib.FromName("HotelLocationMapCell", NSBundle.MainBundle);
        }

        protected HotelLocationMapCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
