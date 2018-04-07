using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeButtonCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeButtonCell");
        public static readonly UINib Nib;

        static HomeButtonCell()
        {
            Nib = UINib.FromName("HomeButtonCell", NSBundle.MainBundle);
        }

        protected HomeButtonCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            BookYourStay.Layer.CornerRadius = 5;
		}
	}
}
