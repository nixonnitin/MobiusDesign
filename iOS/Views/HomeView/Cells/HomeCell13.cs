using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell13 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell13");
        public static readonly UINib Nib;

        static HomeCell13()
        {
            Nib = UINib.FromName("HomeCell13", NSBundle.MainBundle);
        }

        protected HomeCell13(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
