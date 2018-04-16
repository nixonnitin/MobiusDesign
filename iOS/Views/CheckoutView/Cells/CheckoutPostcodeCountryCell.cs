using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views.CheckoutView.Cells
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
    }
}
