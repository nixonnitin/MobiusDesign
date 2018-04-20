using System;

using Foundation;
using Mobius.iOS.Helper;
using UIKit;

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
            TextFieldPostcode.Placeholder = "Post Code";
            TextFieldCountry.Placeholder = "Country";
         

            UIViewHelper.SetViewBorderAndCornerRadiusForTextField(ViewCountry);
            UIViewHelper.SetViewBorderAndCornerRadiusForTextField(ViewPostcode);


		}
	}
}
