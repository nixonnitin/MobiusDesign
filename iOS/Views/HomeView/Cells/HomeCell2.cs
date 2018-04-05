using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell2 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell2");
        public static readonly UINib Nib;

        static HomeCell2()
        {
            Nib = UINib.FromName("HomeCell2", NSBundle.MainBundle);
        }

        protected HomeCell2(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
