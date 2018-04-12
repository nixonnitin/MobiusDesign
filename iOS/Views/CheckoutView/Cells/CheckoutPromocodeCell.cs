using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutPromocodeCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutPromocodeCell");
        public static readonly UINib Nib;

        static CheckoutPromocodeCell()
        {
            Nib = UINib.FromName("CheckoutPromocodeCell", NSBundle.MainBundle);
        }

        protected CheckoutPromocodeCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();

            ViewPromocodeContainer.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewPromocodeContainer.Layer.BorderWidth = 2;
            ViewPromocodeContainer.Layer.CornerRadius = 5;

            LabelPromocode.Font = MobiusHelper.GetFontLightWithSize(14);
            LabelPromocode.TextColor = MobiusHelper.GetColorGray();
            TextPromocode.Font = MobiusHelper.GetFontLightWithSize(14);
        }
    }
}
