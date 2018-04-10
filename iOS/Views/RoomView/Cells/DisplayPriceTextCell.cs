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
            Button_Money.Layer.CornerRadius = 5;
            Button_Points.Layer.BorderWidth = 1;
            Button_Points.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
            Button_Points.Layer.CornerRadius = 5;

		}
	}
}
