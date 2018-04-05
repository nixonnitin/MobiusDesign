using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell7 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell7");
        public static readonly UINib Nib;

        static HomeCell7()
        {
            Nib = UINib.FromName("HomeCell7", NSBundle.MainBundle);
        }

        protected HomeCell7(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
