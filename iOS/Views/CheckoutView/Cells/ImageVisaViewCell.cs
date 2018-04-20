using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class ImageVisaViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("ImageVisaViewCell");
        public static readonly UINib Nib;

        static ImageVisaViewCell()
        {
            Nib = UINib.FromName("ImageVisaViewCell", NSBundle.MainBundle);
        }

        protected ImageVisaViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
