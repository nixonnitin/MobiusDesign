using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class GuestRoomPickerCancelDoneCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GuestRoomPickerCancelDoneCell");
        public static readonly UINib Nib;

        static GuestRoomPickerCancelDoneCell()
        {
            Nib = UINib.FromName("GuestRoomPickerCancelDoneCell", NSBundle.MainBundle);
        }

        protected GuestRoomPickerCancelDoneCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
