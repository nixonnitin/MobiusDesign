using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardDescriptionWithButtonViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RewardDescriptionWithButtonViewCell");
        public static readonly UINib Nib;

        static RewardDescriptionWithButtonViewCell()
        {
            Nib = UINib.FromName("RewardDescriptionWithButtonViewCell", NSBundle.MainBundle);
        }

        protected RewardDescriptionWithButtonViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            ButtonBuyPoints.Layer.CornerRadius = 5;
            ButtonBuyPoints.BackgroundColor = MobiusHelper.GetColorLightGreen();
            ButtonBuyPoints.TintColor = UIColor.White;
            ButtonBuyPoints.SetTitleColor(UIColor.White, UIControlState.Disabled);
            ButtonBuyPoints.Font = MobiusHelper.GetFontBoldWithSize(16);

            LabelRewardDescription.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelRewardDescription.TextColor = MobiusHelper.GetColorGray();

            ViewSeperatorBreak.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();
            ViewMainDescription.BackgroundColor = MobiusHelper.GetColorLightGrey();

		}
	}
}
