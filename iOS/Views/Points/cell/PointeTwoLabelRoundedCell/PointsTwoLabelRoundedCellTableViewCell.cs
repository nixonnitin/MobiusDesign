using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PointsTwoLabelRoundedCellTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PointsTwoLabelRoundedCellTableViewCell");
        public static readonly UINib Nib;

        static PointsTwoLabelRoundedCellTableViewCell()
        {
            Nib = UINib.FromName("PointsTwoLabelRoundedCellTableViewCell", NSBundle.MainBundle);
        }

        protected PointsTwoLabelRoundedCellTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
