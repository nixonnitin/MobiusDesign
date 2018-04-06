using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class MainResultNoResultFoundCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MainResultNoResultFoundCell");
        public static readonly UINib Nib;

        static MainResultNoResultFoundCell()
        {
            Nib = UINib.FromName("MainResultNoResultFoundCell", NSBundle.MainBundle);
        }

        protected MainResultNoResultFoundCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
