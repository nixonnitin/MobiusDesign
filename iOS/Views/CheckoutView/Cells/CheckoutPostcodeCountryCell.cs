using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helper;
namespace Mobius.iOS.Views
{
    public partial class CheckoutPostcodeCountryCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("CheckoutPostcodeCountryCell");
        public static readonly UINib Nib;

        static CheckoutPostcodeCountryCell()
        {
            Nib = UINib.FromName("CheckoutPostcodeCountryCell", NSBundle.MainBundle);
        }

        protected CheckoutPostcodeCountryCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.BackgroundColor = MobiusHelper.GetColorLightGrey();
            ViewMainPostCodeCountry.BackgroundColor = MobiusHelper.GetColorLightGrey();
            ViewPostcode.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewPostcode.Layer.BorderWidth = 2;
            ViewPostcode.Layer.CornerRadius = 5;

            ViewCountry.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            ViewCountry.Layer.BorderWidth = 2;
            ViewCountry.Layer.CornerRadius = 5;

            TextFieldPostcode.Font = MobiusHelper.GetFontLightWithSize(14);
            TextFieldCountry.Font = MobiusHelper.GetFontLightWithSize(14);
        }
    }
}
