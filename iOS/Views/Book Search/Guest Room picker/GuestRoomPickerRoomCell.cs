using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class GuestRoomPickerRoomCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GuestRoomPickerRoomCell");
        public static readonly UINib Nib;

        static GuestRoomPickerRoomCell()
        {
            Nib = UINib.FromName("GuestRoomPickerRoomCell", NSBundle.MainBundle);
        }

        protected GuestRoomPickerRoomCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
