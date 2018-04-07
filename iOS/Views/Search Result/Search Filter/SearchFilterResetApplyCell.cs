using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SearchFilterResetApplyCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SearchFilterResetApplyCell");
        public static readonly UINib Nib;

        static SearchFilterResetApplyCell()
        {
            Nib = UINib.FromName("SearchFilterResetApplyCell", NSBundle.MainBundle);
        }

        protected SearchFilterResetApplyCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
