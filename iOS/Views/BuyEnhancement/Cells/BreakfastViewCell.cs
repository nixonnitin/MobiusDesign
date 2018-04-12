using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BreakfastViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BreakfastViewCell");
        public static readonly UINib Nib;

        static BreakfastViewCell()
        {
            Nib = UINib.FromName("BreakfastViewCell", NSBundle.MainBundle);
        }

        protected BreakfastViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
