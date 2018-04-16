using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class OfferPageOfferCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("OfferPageOfferCell");
        public static readonly UINib Nib;

        static OfferPageOfferCell()
        {
            Nib = UINib.FromName("OfferPageOfferCell", NSBundle.MainBundle);
        }

        protected OfferPageOfferCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            //UIViewHelper.SetShadow(ViewBookingDetailContainer, 50);

            LabelBookingInfo.BackgroundColor = MobiusHelper.GetColorMaroonRed();
            LabelBookingInfo.Font = MobiusHelper.GetFontRegularWithSize(13f);

            LabelOffer.Font = MobiusHelper.GetFontBoldWithSize(16f);

        }
    }
}
