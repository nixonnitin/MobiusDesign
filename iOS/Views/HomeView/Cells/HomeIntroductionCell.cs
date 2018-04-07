using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeIntroductionCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeIntroductionCell");
        public static readonly UINib Nib;

        static HomeIntroductionCell()
        {
            Nib = UINib.FromName("HomeIntroductionCell", NSBundle.MainBundle);
        }

        protected HomeIntroductionCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
