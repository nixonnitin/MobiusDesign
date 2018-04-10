using System;
using CoreAnimation;
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

            UIView_DirectBook.Layer.CornerRadius = 11;

            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(UiView_Price.Bounds, UIRectCorner.BottomRight | UIRectCorner.TopRight, new CoreGraphics.CGSize(10, 10));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = UiView_Price.Bounds;
            maskLayer.Path = maskPath.CGPath;
            UiView_Price.Layer.Mask = maskLayer;

            UIMainView_DirectBook.Layer.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;


		}
	}
}
