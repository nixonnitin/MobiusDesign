﻿using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeOfferCellLarge : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeOfferCellLarge");
        public static readonly UINib Nib;

        static HomeOfferCellLarge()
        {
            Nib = UINib.FromName("HomeOfferCellLarge", NSBundle.MainBundle);
        }

        protected HomeOfferCellLarge(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();



            /*
                        UIBezierPath maskPath = UIBezierPath.FromRoundedRect(LblLimitedOffer.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(10, 10));
                        CAShapeLayer maskLayer = new CAShapeLayer();
                        maskLayer.Frame = LblLimitedOffer.Bounds;
                        maskLayer.Path = maskPath.CGPath;
                        LblLimitedOffer.Layer.Mask = maskLayer;
            */
            LblLimitedOffer.Layer.CornerRadius = 10;


            //this.Layer.MasksToBounds = false;
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