using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelMoreCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelMoreCell");
        public static readonly UINib Nib;

        static HotelMoreCell()
        {
            Nib = UINib.FromName("HotelMoreCell", NSBundle.MainBundle);
        }

        protected HotelMoreCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
