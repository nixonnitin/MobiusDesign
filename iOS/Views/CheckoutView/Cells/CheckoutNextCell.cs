using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutNextCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutNextCell");
        public static readonly UINib Nib;

        static CheckoutNextCell()
        {
            Nib = UINib.FromName("CheckoutNextCell", NSBundle.MainBundle);
        }

        protected CheckoutNextCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorTopHeadingBackground();
            LabelTotalForStay.Font = MobiusHelper.GetFontRegularWithSize(15);
            LabelTotalForStay.TextColor = UIColor.White;

            LabelPrice.Font = MobiusHelper.GetFontBoldWithSize(15);
            LabelPrice.TextColor = UIColor.White;

            LabelOr.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelOr.TextColor = MobiusHelper.GetColorGray();

            LabelTotalPoints.Font = MobiusHelper.GetFontBoldWithSize(15);
            LabelTotalPoints.TextColor = UIColor.White;

            LabelPoints.Font = MobiusHelper.GetFontRegularWithSize(12);
            LabelPoints.TextColor = MobiusHelper.GetColorGray();

            ButtonPriceBreakdown.Font = MobiusHelper.GetFontRegularWithSize(12);
            ButtonPriceBreakdown.SetTitleColor(MobiusHelper.GetColorGray(), UIControlState.Normal);
            //ButtonNext.TextColor = MobiusHelper.GetColorGray();

            ViewInfoLabelContainer.BackgroundColor = MobiusHelper.GetColorInformationBlue();
            ViewInfoLabelContainer.Layer.CornerRadius = 5;

            LabelInfo.Font = MobiusHelper.GetFontRegularWithSize(12);

            ButtonNext.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ButtonNext.SetTitleColor(UIColor.White, UIControlState.Normal);
            ButtonNext.Font = MobiusHelper.GetFontBoldWithSize(15);
            ButtonNext.Layer.CornerRadius = 5;

        }
    }
}
