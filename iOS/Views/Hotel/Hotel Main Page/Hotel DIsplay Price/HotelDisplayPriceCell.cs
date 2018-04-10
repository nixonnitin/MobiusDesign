using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelDisplayPriceCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelDisplayPriceCell");
        public static readonly UINib Nib;

        static HotelDisplayPriceCell()
        {
            Nib = UINib.FromName("HotelDisplayPriceCell", NSBundle.MainBundle);
        }

        protected HotelDisplayPriceCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
