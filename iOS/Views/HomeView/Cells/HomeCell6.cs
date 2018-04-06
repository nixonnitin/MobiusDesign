using System;

using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell6 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell6");
        public static readonly UINib Nib;

        static HomeCell6()
        {
            Nib = UINib.FromName("HomeCell6", NSBundle.MainBundle);
        }

        protected HomeCell6(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LblCityName.Text = "City Name";
            LblRegionName.Text = "Region Name";
		}
	}
}
