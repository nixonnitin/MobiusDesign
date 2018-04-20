using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class ConfirmationHotelDetailsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ConfirmationHotelDetailsTableViewCell");
        public static readonly UINib Nib;

        static ConfirmationHotelDetailsTableViewCell()
        {
            Nib = UINib.FromName("ConfirmationHotelDetailsTableViewCell", NSBundle.MainBundle);
        }

        protected ConfirmationHotelDetailsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
