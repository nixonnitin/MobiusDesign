using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SelectedRoomCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SelectedRoomCell");
        public static readonly UINib Nib;

        static SelectedRoomCell()
        {
            Nib = UINib.FromName("SelectedRoomCell", NSBundle.MainBundle);
        }

        protected SelectedRoomCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
		}
	}
}
