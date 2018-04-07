using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeRateCell : UITableViewCell
    {
        partial void CheckInButton_TouchUpInside(UIButton sender)
        {
            //throw new NotImplementedException();
        }

        public static readonly NSString Key = new NSString("HomeRateCell");
        public static readonly UINib Nib;

        static HomeRateCell()
        {
            Nib = UINib.FromName("HomeRateCell", NSBundle.MainBundle);
        }

        protected HomeRateCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            this.Layer.BackgroundColor = UIColor.White.CGColor;
            this.Layer.CornerRadius = 5;
            CheckInButton.Layer.CornerRadius = 5;



            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(LblLimitedTimeOffer.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = LblLimitedTimeOffer.Bounds;
            maskLayer.Path = maskPath.CGPath;
            LblLimitedTimeOffer.Layer.Mask = maskLayer;

            //this.Layer.MasksToBounds = false;
            //this.Layer.ShadowColor = UIColor.Black.CGColor;
            //this.Layer.ShadowOpacity = 0.8f;
            //this.Layer.ShadowOffset = new CGSize(6, 4);
            //this.Layer.ShadowRadius = 4;
            this.Layer.CornerRadius = 5;
            //this.Layer.BackgroundColor = UIColor.White.CGColor;

            //this.Layer.ShadowPath = UIBezierPath.FromRect(this.Layer.Bounds).CGPath;



		}
	}
}
