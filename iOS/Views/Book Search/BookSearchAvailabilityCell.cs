using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BookSearchAvailabilityCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BookSearchAvailabilityCell");
        public static readonly UINib Nib;

        static BookSearchAvailabilityCell()
        {
            Nib = UINib.FromName("BookSearchAvailabilityCell", NSBundle.MainBundle);
        }

        protected BookSearchAvailabilityCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
