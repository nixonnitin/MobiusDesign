﻿using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeCell16 : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeCell16");
        public static readonly UINib Nib;

        static HomeCell16()
        {
            Nib = UINib.FromName("HomeCell16", NSBundle.MainBundle);
        }

        protected HomeCell16(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();

            this.Layer.MasksToBounds = false;
            this.Layer.ShadowColor = UIColor.Black.CGColor;
            this.Layer.ShadowOpacity = 0.8f;
            this.Layer.ShadowOffset = new CGSize(6, 4);
            this.Layer.ShadowRadius = 4;
            this.Layer.CornerRadius = 5;
            this.Layer.BackgroundColor = UIColor.Red.CGColor;

            this.Layer.ShadowPath = UIBezierPath.FromRect(this.Layer.Bounds).CGPath;


		}
	}
}
