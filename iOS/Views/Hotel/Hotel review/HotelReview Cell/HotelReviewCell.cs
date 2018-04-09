using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelReviewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HotelReviewCell");
        public static readonly UINib Nib;

        static HotelReviewCell()
        {
            Nib = UINib.FromName("HotelReviewCell", NSBundle.MainBundle);
        }

        protected HotelReviewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
    }
}
