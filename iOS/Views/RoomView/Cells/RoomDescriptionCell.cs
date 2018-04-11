using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RoomDescriptionCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RoomDescriptionCell");
        public static readonly UINib Nib;

        static RoomDescriptionCell()
        {
            Nib = UINib.FromName("RoomDescriptionCell", NSBundle.MainBundle);
        }

        protected RoomDescriptionCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LableRoomDescrHeading.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Bold);
            LableRoomDescrHeading.TextColor = UIColor.Black;

            LabelRoomDescription.Font = UIFont.SystemFontOfSize(12,UIFontWeight.Regular);
            LabelRoomDescription.TextColor = UIColor.Gray;

            ButtionReadMoreRoomDescription.SetTitleColor(MobiusHelper.GetColorDarkGreen(), UIControlState.Normal);
            ButtionReadMoreRoomDescription.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
            ButtionReadMoreRoomDescription.Layer.BorderColor = MobiusHelper.GetColorDarkGreen().CGColor;
            ButtionReadMoreRoomDescription.Layer.BorderWidth = 1;

            ButtionReadMoreRoomDescription.Layer.CornerRadius = 5;
            ButtionReadMoreRoomDescription.BackgroundColor = UIColor.White;

        }
	}
}
