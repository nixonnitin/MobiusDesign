using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BookSearchCell2 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BookSearchCell2");
        public static readonly UINib Nib;

        static BookSearchCell2()
        {
            Nib = UINib.FromName("BookSearchCell2", NSBundle.MainBundle);
        }

        protected BookSearchCell2(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
