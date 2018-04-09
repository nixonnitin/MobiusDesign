using System;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PreferencesCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("PreferencesCell");
        public static readonly UINib Nib;

        static PreferencesCell()
        {
            Nib = UINib.FromName("PreferencesCell", NSBundle.MainBundle);
        }

        protected PreferencesCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
