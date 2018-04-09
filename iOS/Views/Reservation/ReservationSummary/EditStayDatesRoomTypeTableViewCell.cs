using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class EditStayDatesRoomTypeTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("EditStayDatesRoomTypeTableViewCell");
        public static readonly UINib Nib;

        static EditStayDatesRoomTypeTableViewCell()
        {
            Nib = UINib.FromName("EditStayDatesRoomTypeTableViewCell", NSBundle.MainBundle);
        }

        protected EditStayDatesRoomTypeTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
