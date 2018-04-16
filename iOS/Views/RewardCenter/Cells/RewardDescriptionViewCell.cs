using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardDescriptionViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RewardDescriptionViewCell");
        public static readonly UINib Nib;

        static RewardDescriptionViewCell()
        {
            Nib = UINib.FromName("RewardDescriptionViewCell", NSBundle.MainBundle);
        }

        protected RewardDescriptionViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LabelDescription.TextAlignment = UITextAlignment.Center;
            LabelDescription.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelDescription.TextColor = MobiusHelper.GetColorGray();

            LabelDescriptionHeading.Font = MobiusHelper.GetFontRegularWithSize(14);
            LabelDescriptionHeading.TextColor = UIColor.Black;


            UIViewHelper.SetShadow(ViewMainForDescription, 5, 0.3f, 3f, 0.2f, 0.2f);

		}
	}
}
