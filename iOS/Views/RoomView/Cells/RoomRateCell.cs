using System;

using Foundation;
using UIKit;
using Mobius.iOS.Helpers;
using CoreAnimation;

namespace Mobius.iOS.Views
{
    public partial class RoomRateCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RoomRateCell");
        public static readonly UINib Nib;

        static RoomRateCell()
        {
            Nib = UINib.FromName("RoomRateCell", NSBundle.MainBundle);
        }

        protected RoomRateCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
		public override void AwakeFromNib()
		{
            base.AwakeFromNib();



            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(ViewMemberLogo.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(10, 10));
            CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = ViewMemberLogo.Bounds;
            maskLayer.Path = maskPath.CGPath;
            ViewMemberLogo.Layer.Mask = maskLayer;


            ViewMemberLogo.Layer.BackgroundColor = MobiusHelper.GetColorMaroonRed().CGColor;
            ViewMainRoomRate.Layer.BackgroundColor = UIColor.White.CGColor;
            ViewContentRoomrate.BackgroundColor = MobiusHelper.GetColorLightBlue();

            LabelMemberLogo.TextColor = UIColor.White;
            LabelActualPrice.TextColor = UIColor.Red;
            LabelPerNight.TextColor = UIColor.Gray;

            LabelPerNight.TextAlignment = UITextAlignment.Right;
            LabelActualPrice.TextAlignment = UITextAlignment.Right;
            LabelPriceNow.TextAlignment = UITextAlignment.Right;

            LabelPriceNow.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
            LabelPerNight.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Medium);
            LabelMemberOnlyRate.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Heavy);

            LableContentHeading2.TextColor = MobiusHelper.GetColorDarkGreen();
            LableContentHeading.TextColor = MobiusHelper.GetColorDarkGreen();
            ButtonCancelPolicy.SetTitleColor(MobiusHelper.GetColorDarkGreen(), UIControlState.Normal);
            ButtonPriceBreakDown.SetTitleColor(MobiusHelper.GetColorDarkGreen(), UIControlState.Normal);
            //ButtonCancelPolicy.TitleLabel.TextColor = MobiusHelper.GetColorDarkGreen();
            //ButtonPriceBreakDown.TitleLabel.TextColor = MobiusHelper.GetColorDarkGreen();

            ButtonBookNow.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ButtonBookNow.TitleLabel.TextColor = UIColor.White;

                                

            //new UIColor(red: 0.58f, green: 0.13f, blue: 0.18f, alpha: 1.0f)


		}
	}
}
