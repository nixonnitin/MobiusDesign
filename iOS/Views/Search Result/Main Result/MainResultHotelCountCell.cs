using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class MainResultHotelCountCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainResultHotelCountCell");
        public static readonly UINib Nib;

        static MainResultHotelCountCell()
        {
            Nib = UINib.FromName("MainResultHotelCountCell", NSBundle.MainBundle);
        }

        protected MainResultHotelCountCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
