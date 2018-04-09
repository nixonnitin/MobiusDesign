using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PriceAndBookCheapCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PriceAndBookCheapCell");
        public static readonly UINib Nib;

        static PriceAndBookCheapCell()
        {
            Nib = UINib.FromName("PriceAndBookCheapCell", NSBundle.MainBundle);
        }

        protected PriceAndBookCheapCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
