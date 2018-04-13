using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardCenterMemberHeaderViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RewardCenterMemberHeaderViewCell");
        public static readonly UINib Nib;

        static RewardCenterMemberHeaderViewCell()
        {
            Nib = UINib.FromName("RewardCenterMemberHeaderViewCell", NSBundle.MainBundle);
        }

        protected RewardCenterMemberHeaderViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();

            ImageMemeberHeader.Layer.CornerRadius = ImageMemeberHeader.Frame.Size.Width / 2;
            ImageMemeberHeader.Layer.MasksToBounds = true;

            LabelMemberName.Font = MobiusHelper.GetFontBoldWithSize(16);
            LabelMemberName.TextColor = UIColor.Black;

            LabelMemberSince.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelMemberSince.TextColor = MobiusHelper.GetColorGray();


		}
	}
}
