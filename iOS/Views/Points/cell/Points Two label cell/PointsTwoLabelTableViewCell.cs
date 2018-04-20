using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PointsTwoLabelTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PointsTwoLabelTableViewCell");
        public static readonly UINib Nib;

        static PointsTwoLabelTableViewCell()
        {
            Nib = UINib.FromName("PointsTwoLabelTableViewCell", NSBundle.MainBundle);
        }

        protected PointsTwoLabelTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
