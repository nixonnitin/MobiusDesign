using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SearchFilterDropDownCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SearchFilterDropDownCell");
        public static readonly UINib Nib;

        static SearchFilterDropDownCell()
        {
            Nib = UINib.FromName("SearchFilterDropDownCell", NSBundle.MainBundle);
        }

        protected SearchFilterDropDownCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
