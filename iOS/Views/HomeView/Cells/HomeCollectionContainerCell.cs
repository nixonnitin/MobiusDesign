using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCollectionContainerCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCollectionContainerCell");
        public static readonly UINib Nib;

        static HomeCollectionContainerCell()
        {
            Nib = UINib.FromName("HomeCollectionContainerCell", NSBundle.MainBundle);
        }

        protected HomeCollectionContainerCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
