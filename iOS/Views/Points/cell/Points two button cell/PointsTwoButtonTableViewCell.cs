using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PointsTwoButtonTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PointsTwoButtonTableViewCell");
        public static readonly UINib Nib;

        static PointsTwoButtonTableViewCell()
        {
            Nib = UINib.FromName("PointsTwoButtonTableViewCell", NSBundle.MainBundle);
        }

        protected PointsTwoButtonTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
