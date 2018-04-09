using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class DisplayPriceTextCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("DisplayPriceTextCell");
        public static readonly UINib Nib;

        static DisplayPriceTextCell()
        {
            Nib = UINib.FromName("DisplayPriceTextCell", NSBundle.MainBundle);
        }

        protected DisplayPriceTextCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
		}
	}
}
