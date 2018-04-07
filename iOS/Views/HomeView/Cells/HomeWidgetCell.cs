using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeWidgetCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeWidgetCell");
        public static readonly UINib Nib;

        static HomeWidgetCell()
        {
            Nib = UINib.FromName("HomeWidgetCell", NSBundle.MainBundle);
        }

        protected HomeWidgetCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();

            this.Layer.MasksToBounds = false;
            //this.Layer.ShadowColor = UIColor.Black.CGColor;
            //this.Layer.ShadowOpacity = 0.8f;
            //this.Layer.ShadowOffset = new CGSize(6, 4);
            //this.Layer.ShadowRadius = 4;
            this.Layer.CornerRadius = 5;
            //this.Layer.BackgroundColor = UIColor.Red.CGColor;

            //this.Layer.ShadowPath = UIBezierPath.FromRect(this.Layer.Bounds).CGPath;


		}
	}
}
