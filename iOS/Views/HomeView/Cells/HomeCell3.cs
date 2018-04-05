using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell3 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell3");
        public static readonly UINib Nib;

        static HomeCell3()
        {
            Nib = UINib.FromName("HomeCell3", NSBundle.MainBundle);
        }

        protected HomeCell3(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
