using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell2 : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell2");
        public static readonly UINib Nib;

        static HomeCell2()
        {
            Nib = UINib.FromName("HomeCell2", NSBundle.MainBundle);
        }

        protected HomeCell2(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            //LabelOuterLayout.Layer.CornerRadius = 5;

            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(LabelOuterLayout.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = LabelOuterLayout.Bounds;
            maskLayer.Path = maskPath.CGPath;
            LabelOuterLayout.Layer.Mask = maskLayer;


            UIBezierPath maskPathImage = UIBezierPath.FromRoundedRect(HotelImage.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
            CAShapeLayer maskLayerImage = new CAShapeLayer();
            maskLayerImage.Frame = HotelImage.Bounds;
            maskLayerImage.Path = maskPathImage.CGPath;
            HotelImage.Layer.Mask = maskLayerImage;
            //HotelImage.Layer.FillMode = "";




            this.Layer.MasksToBounds = false;
            this.Layer.ShadowColor = UIColor.Black.CGColor;
            this.Layer.ShadowOpacity = 0.4f;
            this.Layer.ShadowOffset = new CGSize(1,4);
            this.Layer.ShadowRadius = 4;
            this.Layer.CornerRadius = 5;
            this.Layer.BackgroundColor = UIColor.White.CGColor;

            this.Layer.ShadowPath = UIBezierPath.FromRect(this.Layer.Bounds).CGPath;
            //UIBezierPath.
            //UIBezierPath.FromRoundedRect(this.Layer.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
            this.Layer.ShouldRasterize = true;




            //LblHotelName.Layer.ShadowColor = UIColor.Red.CGColor;
            //LblHotelName.Layer.ShadowOpacity = 0.6f;
            //LblHotelName.Layer.ShadowRadius = 20;
            //LblHotelName.Layer.ShadowOffset = new CGSize(0, 0);

            //layer.BackgroundColor = UIColor.Red.CGColor;
            /*layer.ShadowOffset = new CGSize(1, 1);
            layer.ShadowColor = UIColor.Black.CGColor;
            layer.BorderWidth = 7;
            layer.BorderColor = UIColor.Clear.CGColor;

            layer.ShadowRadius = 4.0f;
            layer.ShadowOpacity = 0.80f;
            //layer.ShadowPath = new UIBezierPath(layer) CGPath;// (UIBezierPath layer.Bounds) CGPath];

*/
            /*
            this.Layer.CornerRadius = 5;
            this.Layer.BorderWidth = 2;
            this.Layer.BorderColor = UIColor.Green.CGColor;
            this.Layer.ShadowColor = UIColor.Red.CGColor;
            this.Layer.ShadowRadius = 5;
            
            this.Layer.MasksToBounds = false;

            this.Layer.ShadowColor = UIColor.Black.CGColor;
            this.Layer.ShadowOpacity = 0.5f;
            this.Layer.ShadowOffset = new CGSize(-1,1);
            this.Layer.ShadowRadius = 1;


            this.Layer.ShadowPath = new CGPath();
            this.Layer.ShouldRasterize = true;
            //this.Layer.RasterizationScale = Scale ? UIScreen.Main.Scale : 1;
            */





		}
	}
}
