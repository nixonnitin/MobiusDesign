using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SearchFilterSwitchCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SearchFilterSwitchCell");
        public static readonly UINib Nib;

        static SearchFilterSwitchCell()
        {
            Nib = UINib.FromName("SearchFilterSwitchCell", NSBundle.MainBundle);
        }

        protected SearchFilterSwitchCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
