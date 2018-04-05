using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell4 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell4");
        public static readonly UINib Nib;

        static HomeCell4()
        {
            Nib = UINib.FromName("HomeCell4", NSBundle.MainBundle);
        }

        protected HomeCell4(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
