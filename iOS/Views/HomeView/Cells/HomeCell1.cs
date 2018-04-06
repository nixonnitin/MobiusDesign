using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell1 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell1");
        public static readonly UINib Nib;

        static HomeCell1()
        {
            Nib = UINib.FromName("HomeCell1", NSBundle.MainBundle);
        }

        protected HomeCell1(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.

        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            BookYourStay.Layer.CornerRadius = 5;
		}
	}
}
