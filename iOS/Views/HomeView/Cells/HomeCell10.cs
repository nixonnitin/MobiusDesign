using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell10 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell10");
        public static readonly UINib Nib;

        static HomeCell10()
        {
            Nib = UINib.FromName("HomeCell10", NSBundle.MainBundle);
        }

        protected HomeCell10(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
