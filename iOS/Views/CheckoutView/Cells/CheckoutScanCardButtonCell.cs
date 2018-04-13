using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutScanCardButtonCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutScanCardButtonCell");
        public static readonly UINib Nib;

        static CheckoutScanCardButtonCell()
        {
            Nib = UINib.FromName("CheckoutScanCardButtonCell", NSBundle.MainBundle);
        }

        protected CheckoutScanCardButtonCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            ViewContainer.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ViewContainer.Layer.CornerRadius = 5;
            LabelScanCard.Font = MobiusHelper.GetFontBoldWithSize(15);
            LabelUsingCamera.Font = MobiusHelper.GetFontRegularWithSize(12);

        }

    }
}
