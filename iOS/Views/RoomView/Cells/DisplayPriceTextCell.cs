using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class DisplayPriceTextCell : UITableViewCell
    {
        partial void Button_Points_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }

        partial void Button_Money_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }

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
            Button_Money.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            Button_Money.TitleLabel.TextColor = UIColor.White;
            TextDisplayPrice.Font = MobiusHelper.GetFontBoldWithSize(18);
            TextDisplayPrice.TextColor = UIColor.Black;
                            
            Button_Points.Layer.BorderWidth = 1;
            Button_Points.Layer.BorderColor = MobiusHelper.GetColorDarkGreen().CGColor;
            Button_Points.Layer.CornerRadius = 5;
            Button_Points.TitleLabel.TextColor = MobiusHelper.GetColorDarkGreen();

		}
	}
}
