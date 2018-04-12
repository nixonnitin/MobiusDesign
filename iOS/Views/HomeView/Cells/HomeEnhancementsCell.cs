using System;
using CoreGraphics;
using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HomeEnhancementsCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeEnhancementsCell");
        public static readonly UINib Nib;

        static HomeEnhancementsCell()
        {
            Nib = UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle);
        }

        protected HomeEnhancementsCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();

            //this.Layer.MasksToBounds = false;
            //this.Layer.ShadowColor = UIColor.Black.CGColor;
            //this.Layer.ShadowOpacity = 0.8f;
            //this.Layer.ShadowOffset = new CGSize(6, 4);
            //this.Layer.ShadowRadius = 4;
            this.Layer.CornerRadius = 5;
            //this.Layer.BackgroundColor = UIColor.Red.CGColor;
            UIViewHelper.SetShadow(this, 5, 0.3f, 3f, 0.2f, 0.2f); 
            //this.Layer.ShadowPath = UIBezierPath.FromRect(this.Layer.Bounds).CGPath;


        }
    }
}
