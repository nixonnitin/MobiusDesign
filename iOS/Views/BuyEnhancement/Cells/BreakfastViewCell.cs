using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BreakfastViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BreakfastViewCell");
        public static readonly UINib Nib;

        static BreakfastViewCell()
        {
            Nib = UINib.FromName("BreakfastViewCell", NSBundle.MainBundle);
        }

        protected BreakfastViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();

            ImageView.Layer.CornerRadius = 5;

            ButtonDollar.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ButtonDollar.Layer.CornerRadius = 5;
            ButtonDollar.SetTitleColor(UIColor.White, UIControlState.Normal);


            ButtonPoints.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ButtonPoints.Layer.CornerRadius = 5;
            ButtonPoints.SetTitleColor(UIColor.White, UIControlState.Normal);

            LabelBreakfast.Font = MobiusHelper.GetFontBoldWithSize(14);
            LabelBreakfast.TextColor = UIColor.Black;

            LabelBreakFastDescription.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelBreakFastDescription.TextColor = MobiusHelper.GetColorGray();

		}
	}
}
