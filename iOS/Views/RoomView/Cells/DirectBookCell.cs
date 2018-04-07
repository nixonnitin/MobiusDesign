using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class DirectBookCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("DirectBookCell");
        public static readonly UINib Nib;

        static DirectBookCell()
        {
            Nib = UINib.FromName("DirectBookCell", NSBundle.MainBundle);
        }

        protected DirectBookCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
		}
	}
}
