using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PollTopCellTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PollTopCellTableViewCell");
        public static readonly UINib Nib;

        static PollTopCellTableViewCell()
        {
            Nib = UINib.FromName("PollTopCellTableViewCell", NSBundle.MainBundle);
        }

        protected PollTopCellTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
