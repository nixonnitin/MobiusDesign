using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RewardsTableViewCell");
        public static readonly UINib Nib;

        static RewardsTableViewCell()
        {
            Nib = UINib.FromName("RewardsTableViewCell", NSBundle.MainBundle);
        }

        protected RewardsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LabelHeadRowDate.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelHeadRowDate.TextColor = MobiusHelper.GetColorGray();

            LabelHeadRowStatus.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelHeadRowStatus.TextColor = MobiusHelper.GetColorGray();

            LabelHeadRowRewardName.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelHeadRowRewardName.TextColor = MobiusHelper.GetColorGray();

            LabelRowDateValue.Font = MobiusHelper.GetFontRegularWithSize(13);
            LabelRowDateValue.TextColor = UIColor.Black;

            LabelStatusValue.Font = MobiusHelper.GetFontRegularWithSize(13);
            LabelStatusValue.TextColor = UIColor.Black;

            LabelRewardNameValue.Font = MobiusHelper.GetFontRegularWithSize(13);
            LabelRewardNameValue.TextColor = UIColor.Black;

            ViewBreakLine.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();

		}



	}
}
