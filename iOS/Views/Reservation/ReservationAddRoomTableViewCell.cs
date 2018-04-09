using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class ReservationAddRoomTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ReservationAddRoomTableViewCell");
        public static readonly UINib Nib;

        static ReservationAddRoomTableViewCell()
        {
            Nib = UINib.FromName("ReservationAddRoomTableViewCell", NSBundle.MainBundle);
        }

        protected ReservationAddRoomTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
