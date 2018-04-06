using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell11 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell11");
        public static readonly UINib Nib;

        static HomeCell11()
        {
            Nib = UINib.FromName("HomeCell11", NSBundle.MainBundle);
        }

        protected HomeCell11(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
