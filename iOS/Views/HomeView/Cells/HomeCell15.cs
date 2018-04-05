using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell15 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell15");
        public static readonly UINib Nib;

        static HomeCell15()
        {
            Nib = UINib.FromName("HomeCell15", NSBundle.MainBundle);
        }

        protected HomeCell15(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}