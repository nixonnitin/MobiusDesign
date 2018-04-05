using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell14 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell14");
        public static readonly UINib Nib;

        static HomeCell14()
        {
            Nib = UINib.FromName("HomeCell14", NSBundle.MainBundle);
        }

        protected HomeCell14(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
