using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RoomNameCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RoomNameCell");
        public static readonly UINib Nib;

        static RoomNameCell()
        {
            Nib = UINib.FromName("RoomNameCell", NSBundle.MainBundle);
        }

        protected RoomNameCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LabelRoomName.Font = UIFont.BoldSystemFontOfSize(18);
            LabelRoomPrice.Font = UIFont.BoldSystemFontOfSize(18);
		}
	}
}
