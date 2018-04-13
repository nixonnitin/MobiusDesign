using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class SearchAmentiesButtonViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("SearchAmentiesButtonViewCell");
        public static readonly UINib Nib;

        static SearchAmentiesButtonViewCell()
        {
            Nib = UINib.FromName("SearchAmentiesButtonViewCell", NSBundle.MainBundle);
        }

        protected SearchAmentiesButtonViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
