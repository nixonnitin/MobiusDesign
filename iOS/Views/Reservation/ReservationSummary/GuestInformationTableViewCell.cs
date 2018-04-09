using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class GuestInformationTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("GuestInformationTableViewCell");
        public static readonly UINib Nib;

        static GuestInformationTableViewCell()
        {
            Nib = UINib.FromName("GuestInformationTableViewCell", NSBundle.MainBundle);
        }

        protected GuestInformationTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
