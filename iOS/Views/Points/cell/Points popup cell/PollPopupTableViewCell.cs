using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PollPopupTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PollPopupTableViewCell");
        public static readonly UINib Nib;

        static PollPopupTableViewCell()
        {
            Nib = UINib.FromName("PollPopupTableViewCell", NSBundle.MainBundle);
        }

        protected PollPopupTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
