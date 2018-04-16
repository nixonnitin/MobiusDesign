using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RewardsTableViewCell");
        public static readonly UINib Nib;

        static RewardsTableViewCell()
        {
            Nib = UINib.FromName("RewardsTableViewCell", NSBundle.MainBundle);
        }

        protected RewardsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
