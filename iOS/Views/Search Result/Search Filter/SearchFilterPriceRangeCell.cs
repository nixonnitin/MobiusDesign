using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SearchFilterPriceRangeCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SearchFilterPriceRangeCell");
        public static readonly UINib Nib;

        static SearchFilterPriceRangeCell()
        {
            Nib = UINib.FromName("SearchFilterPriceRangeCell", NSBundle.MainBundle);
        }

        protected SearchFilterPriceRangeCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
