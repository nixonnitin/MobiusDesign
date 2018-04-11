using System;
using CoreAnimation;
using Foundation;
using Mobius.iOS.Helper;
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

            UiView_Price.BackgroundColor = UIColor.Black;

            LabelDirectPrice.Font = MobiusHelper.GetFontBoldWithSize(14);
            LabelDirectPrice.TextColor = UIColor.White;

            LabelDirectTextStatic.Font = MobiusHelper.GetFontItalicWithSize(12);
            UIMainView_DirectBook.BackgroundColor = MobiusHelper.GetColorDarkGreen();

		}
	}
}
