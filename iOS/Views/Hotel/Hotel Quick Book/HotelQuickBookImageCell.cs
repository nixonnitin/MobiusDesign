using System;
using CoreAnimation;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelQuickBookImageCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelQuickBookImageCell");
        public static readonly UINib Nib;

        static HotelQuickBookImageCell()
        {
            Nib = UINib.FromName("HotelQuickBookImageCell", NSBundle.MainBundle);
        }

        protected HotelQuickBookImageCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();



		}
	}
}
