using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelLabelCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelLabelCell");
        public static readonly UINib Nib;

        static HotelLabelCell()
        {
            Nib = UINib.FromName("HotelLabelCell", NSBundle.MainBundle);
        }

        protected HotelLabelCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
