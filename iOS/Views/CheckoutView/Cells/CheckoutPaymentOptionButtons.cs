using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class CheckoutPaymentOptionButtons : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutPaymentOptionButtons");
        public static readonly UINib Nib;

        static CheckoutPaymentOptionButtons()
        {
            Nib = UINib.FromName("CheckoutPaymentOptionButtons", NSBundle.MainBundle);
        }

        protected CheckoutPaymentOptionButtons(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            //SegmentPay.TintColor = 
        }
    }
}
