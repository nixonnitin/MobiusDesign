using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class MyReservationsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("MyReservationsTableViewCell");
        public static readonly UINib Nib;

        static MyReservationsTableViewCell()
        {
            Nib = UINib.FromName("MyReservationsTableViewCell", NSBundle.MainBundle);
        }

        protected MyReservationsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
