using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutPriceBreakdownCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutPriceBreakdownCell");
        public static readonly UINib Nib;

        static CheckoutPriceBreakdownCell()
        {
            Nib = UINib.FromName("CheckoutPriceBreakdownCell", NSBundle.MainBundle);
        }

        protected CheckoutPriceBreakdownCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            ViewSeperator.BackgroundColor = MobiusHelper.GetColorLightGrey();

            LabelDetail.Font = MobiusHelper.GetFontRegularWithSize(16);
            LabelAmount.Font = MobiusHelper.GetFontRegularWithSize(16);
        }
    }
}
