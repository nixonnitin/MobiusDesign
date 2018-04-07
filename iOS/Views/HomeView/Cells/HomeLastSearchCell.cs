using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeLastSearchCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeLastSearchCell");
        public static readonly UINib Nib;

        static HomeLastSearchCell()
        {
            Nib = UINib.FromName("HomeLastSearchCell", NSBundle.MainBundle);
        }

        protected HomeLastSearchCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
