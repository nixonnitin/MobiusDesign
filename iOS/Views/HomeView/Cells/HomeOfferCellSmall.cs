using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeOfferCellSmall : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomeOfferCellSmall");
        public static readonly UINib Nib;

        static HomeOfferCellSmall()
        {
            Nib = UINib.FromName("HomeOfferCellSmall", NSBundle.MainBundle);
        }

        protected HomeOfferCellSmall(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LimitedOfferLayout.Layer.CornerRadius = 12;
            offerLayout.Layer.BackgroundColor = UIColor.White.CGColor;
            offerLayout.Layer.CornerRadius = 5;

            offerLayout.Layer.MasksToBounds = false;
            //offerLayout.Layer.ShadowColor = UIColor.Black.CGColor;
            //offerLayout.Layer.ShadowOpacity = 0.1f;
            //offerLayout.Layer.ShadowOffset = new CGSize(3, 1);
            //offerLayout.Layer.ShadowRadius = 100;
            offerLayout.Layer.CornerRadius = 5;
            //offerLayout.Layer.BackgroundColor = UIColor.White.CGColor;

            //offerLayout.Layer.ShadowPath = UIBezierPath.FromRect(offerLayout.Layer.Bounds).CGPath;
            //UIBezierPath.
            //UIBezierPath.FromRoundedRect(this.Layer.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
            //offerLayout.Layer.ShouldRasterize = true;


            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(OfferImage.Bounds, UIRectCorner.TopLeft | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = OfferImage.Bounds;
            maskLayer.Path = maskPath.CGPath;
            OfferImage.Layer.Mask = maskLayer;


		}
	}
}
