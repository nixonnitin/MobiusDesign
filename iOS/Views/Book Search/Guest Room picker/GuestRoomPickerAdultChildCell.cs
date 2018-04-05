using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class GuestRoomPickerAdultChildCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GuestRoomPickerAdultChildCell");
        public static readonly UINib Nib;

        static GuestRoomPickerAdultChildCell()
        {
            Nib = UINib.FromName("GuestRoomPickerAdultChildCell", NSBundle.MainBundle);
        }

        protected GuestRoomPickerAdultChildCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
