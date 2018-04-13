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

        /*UIKit.UILabel LabelAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelDetail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewSeperator { get; set; }
        */
        public UILabel labelAmount{
            get { return LabelAmount; }
            set { LabelAmount = value; }
        }

        public UILabel labelDetail
        {
            get { return LabelDetail; }
            set { LabelDetail = value; }
        }

        public UIView viewSeperator
        {
            get { return ViewSeperator; }
            set { ViewSeperator = value; }
        }
    }
}
