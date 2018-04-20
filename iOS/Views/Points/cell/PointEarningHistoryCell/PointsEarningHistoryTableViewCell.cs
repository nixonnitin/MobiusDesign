using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PointsEarningHistoryTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PointsEarningHistoryTableViewCell");
        public static readonly UINib Nib;

        static PointsEarningHistoryTableViewCell()
        {
            Nib = UINib.FromName("PointsEarningHistoryTableViewCell", NSBundle.MainBundle);
        }

        protected PointsEarningHistoryTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

        }


         
    }
}
