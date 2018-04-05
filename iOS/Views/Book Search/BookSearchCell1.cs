using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BookSearchCell1 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("BookSearchCell1");
        public static readonly UINib Nib;

        static BookSearchCell1()
        {
            Nib = UINib.FromName("BookSearchCell1", NSBundle.MainBundle);
        }

        protected BookSearchCell1(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
