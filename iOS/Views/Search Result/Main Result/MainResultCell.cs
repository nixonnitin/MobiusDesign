using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class MainResultCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainResultCell");
        public static readonly UINib Nib;

        static MainResultCell()
        {
            Nib = UINib.FromName("MainResultCell", NSBundle.MainBundle);
        }

        protected MainResultCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
