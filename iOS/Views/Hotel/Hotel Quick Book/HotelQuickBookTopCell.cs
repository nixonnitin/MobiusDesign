using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelQuickBookTopCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelQuickBookTopCell");
        public static readonly UINib Nib;

        static HotelQuickBookTopCell()
        {
            Nib = UINib.FromName("HotelQuickBookTopCell", NSBundle.MainBundle);
        }

        protected HotelQuickBookTopCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
