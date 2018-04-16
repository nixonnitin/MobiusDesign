using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class ImageWithHeadingViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ImageWithHeadingViewCell");
        public static readonly UINib Nib;

        static ImageWithHeadingViewCell()
        {
            Nib = UINib.FromName("ImageWithHeadingViewCell", NSBundle.MainBundle);
        }

        protected ImageWithHeadingViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LabelHeadingReward.Font = MobiusHelper.GetFontBoldWithSize(18);
            LabelHeadingReward.TextColor = UIColor.Black;
		}
	}
}
