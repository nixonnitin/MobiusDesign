using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BillingInformationTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BillingInformationTableViewCell");
        public static readonly UINib Nib;

        static BillingInformationTableViewCell()
        {
            Nib = UINib.FromName("BillingInformationTableViewCell", NSBundle.MainBundle);
        }

        protected BillingInformationTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
