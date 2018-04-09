using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelSubPageCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelSubPageCell");
        public static readonly UINib Nib;

        static HotelSubPageCell()
        {
            Nib = UINib.FromName("HotelSubPageCell", NSBundle.MainBundle);
        }

        protected HotelSubPageCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
