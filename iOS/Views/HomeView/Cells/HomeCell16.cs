using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell16 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell16");
        public static readonly UINib Nib;

        static HomeCell16()
        {
            Nib = UINib.FromName("HomeCell16", NSBundle.MainBundle);
        }

        protected HomeCell16(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
