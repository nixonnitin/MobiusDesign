﻿using System;

using Foundation;
using UIKit;

using CoreAnimation;
using Mobius.iOS.Helper;

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

            //ViewMainRoomRate.Layer.BorderColor = UIColor.Gray.CGColor;
            //ViewMainRoomRate.Layer.BorderWidth = 2;
            //ViewMainRoomRate.Layer.CornerRadius = 10;  
            ViewMainRoomRate.Layer.BackgroundColor = UIColor.White.CGColor;

           // UIViewHelper.SetShadow(ViewMainRoomRate, 5); 
            UIViewHelper.SetShadow(ViewMainRoomRate, 5, 0.3f, 3f, 0.2f, 0.2f); 

            /*
            ViewOfferOnBooking.Layer.BorderColor = UIColor.Gray.CGColor;
            ViewOfferOnBooking.Layer.BorderWidth = 2;
            ViewOfferOnBooking.Layer.CornerRadius = 10;
            ViewOfferOnBooking.Layer.BackgroundColor = UIColor.White.CGColor;

*/
            ViewMemberLogo.Layer.BackgroundColor = MobiusHelper.GetColorMaroonRed().CGColor;

            ViewContentRoomrate.BackgroundColor = MobiusHelper.GetColorLightBlue();



            LabelMemberLogo.TextColor = UIColor.White;
            LabelMemberLogo.Font =  UIFont.SystemFontOfSize(10, UIFontWeight.Bold);

            LabelActualPrice.TextColor = UIColor.Red;
            LabelPerNight.TextColor = UIColor.Gray;

            LabelPerNight.TextAlignment = UITextAlignment.Right;
            LabelActualPrice.TextAlignment = UITextAlignment.Right;
            LabelPriceNow.TextAlignment = UITextAlignment.Right;

            LabelPriceNow.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
            LabelPerNight.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Medium);
            LabelMemberOnlyRate.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Bold);

            LableContentHeading2.TextColor = MobiusHelper.GetColorDarkGreen();
            LableContentHeading.TextColor = MobiusHelper.GetColorDarkGreen();

            LableContentHeading2.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Bold);
            LableContentHeading.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Bold);


            ButtonCancelPolicy.SetTitleColor(MobiusHelper.GetColorDarkGreen(), UIControlState.Normal);
            ButtonPriceBreakDown.SetTitleColor(MobiusHelper.GetColorDarkGreen(), UIControlState.Normal);
            //ButtonCancelPolicy.TitleLabel.TextColor = MobiusHelper.GetColorDarkGreen();
            //ButtonPriceBreakDown.TitleLabel.TextColor = MobiusHelper.GetColorDarkGreen();

            ButtonBookNow.SetTitleColor(UIColor.White, UIControlState.Normal);
            ButtonBookNow.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
            ButtonBookNow.BackgroundColor = MobiusHelper.GetColorDarkGreen();
            ButtonBookNow.Layer.CornerRadius = 5;


            ViewMainRoomRate.Layer.BackgroundColor = UIColor.White.CGColor;


            LabelOfferBooking.BackgroundColor = MobiusHelper.GetColorYellow();

            LabelOfferBooking.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Regular);
            LabelOfferBooking.TextColor = UIColor.Gray;

            /*
             
            UIBezierPath maskPathView = UIBezierPath.FromRoundedRect(LabelOfferBooking.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5,5));
            CAShapeLayer maskLayerView = new CAShapeLayer();
            maskLayerView.Frame = LabelOfferBooking.Bounds;
            maskLayerView.Path = maskPathView.CGPath;
            LabelOfferBooking.Layer.Mask = maskLayerView;
            */

            LabelOfferBooking.TextAlignment = UITextAlignment.Center;
            LabelOfferBooking.Text = "  Earn 75 Points With This Booking!  ";

            ViewTopSeperateLine.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();
            ViewBottomSeperateLine.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();



            //new UIColor(red: 0.58f, green: 0.13f, blue: 0.18f, alpha: 1.0f)


		}
	}
}
