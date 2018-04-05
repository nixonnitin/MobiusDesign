using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class LocationChooseCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("LocationChooseCell");
        public static readonly UINib Nib;

        static LocationChooseCell()
        {
            Nib = UINib.FromName("LocationChooseCell", NSBundle.MainBundle);
        }

        protected LocationChooseCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
