using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PriceBreakDownTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PriceBreakDownTableViewCell");
        public static readonly UINib Nib;

        static PriceBreakDownTableViewCell()
        {
            Nib = UINib.FromName("PriceBreakDownTableViewCell", NSBundle.MainBundle);
        }

        protected PriceBreakDownTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
