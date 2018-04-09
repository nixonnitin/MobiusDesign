using System;

using Foundation;
using UIKit;
using CoreAnimation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public partial class HomePopularDestinationsCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("HomePopularDestinationsCell");
        public static readonly UINib Nib;

        static HomePopularDestinationsCell()
        {
            Nib = UINib.FromName("HomePopularDestinationsCell", NSBundle.MainBundle);
        }

        protected HomePopularDestinationsCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            LblCityName.Text = "City Name";
            LblRegionName.Text = "Region Name";
            //DestinationMainImage.Layer.CornerRadius = 5;
            //DestinationSubImageTop.Layer.CornerRadius = 5;
            //UIBezierPath maskPath = UIBezierPath.FromRoundedRect(DestinationMainImage.Bounds, UIRectCorner.TopLeft , new CoreGraphics.CGSize(5, 5));
            //CAShapeLayer maskLayer = new CAShapeLayer();
            //maskLayer.Frame = DestinationMainImage.Bounds;
            //maskLayer.Path = maskPath.CGPath;
            //DestinationMainImage.Layer.Mask = maskLayer;

            //UIBezierPath maskPathSub = UIBezierPath.FromRoundedRect(DestinationSubImageTop.Bounds, UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
            //CAShapeLayer maskLayerSub = new CAShapeLayer();
            //maskLayer.Frame = DestinationSubImageTop.Bounds;
            //maskLayer.Path = maskPathSub.CGPath;
            //DestinationSubImageTop.Layer.Mask = maskLayerSub;

		}
	}
}
