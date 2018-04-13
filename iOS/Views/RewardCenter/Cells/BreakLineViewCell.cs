using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BreakLineViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BreakLineViewCell");
        public static readonly UINib Nib;

        static BreakLineViewCell()
        {
            Nib = UINib.FromName("BreakLineViewCell", NSBundle.MainBundle);
        }

        protected BreakLineViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
