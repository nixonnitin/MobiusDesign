using System;
using Foundation;
using UIKit;
using CoreAnimation;
namespace Mobius.iOS.Helper
{
    public static class MobiusHelper
    {
        
        public static UIColor GetColorDarkGreen(){
            return new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f); 
        }
        public static UIColor GetColorMaroonRed()
        {
            return new UIColor(red: 0.58f, green: 0.13f, blue: 0.18f, alpha: 1.0f); 
        }
        public static UIColor GetColorTopHeadingBackground()
        {
            return new UIColor(red: 0.20f, green: 0.20f, blue: 0.20f, alpha: 1.0f); 
        }
        public static UIColor GetColorGray()
        {
            return new UIColor(red: 0.55f, green: 0.55f, blue: 0.55f, alpha: 1.0f);
        }
        /*
            Family:Roboto Font names:Roboto-Regular
            Family:Roboto Font names:Roboto-Black
            Family:Roboto Font names:Roboto-Light
            Family:Roboto Font names:Roboto-BoldItalic
            Family:Roboto Font names:Roboto-LightItalic
            Family:Roboto Font names:Roboto-Thin
            Family:Roboto Font names:Roboto-MediumItalic
            Family:Roboto Font names:Roboto-Medium
            Family:Roboto Font names:Roboto-Bold
            Family:Roboto Font names:Roboto-BlackItalic
            Family:Roboto Font names:Roboto-Italic
            Family:Roboto Font names:Roboto-ThinItalic
        */

        public static UIFont GetFontRegularWithSize(nfloat fontSize){
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Regular", fontSize);
            return font;
        }

        public static UIFont GetFontBlackWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Black", fontSize);
            return font;
        }

        public static UIFont GetFontLightWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Light", fontSize);
            return font;
        }

        public static UIFont GetFontBoldItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-BoldItalic", fontSize);
            return font;
        }

        public static UIFont GetFontLightItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-LightItalic", fontSize);
            return font;
        }

        public static UIFont GetFontThinWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Thin", fontSize);
            return font;
        }

        public static UIFont GetFontMediumItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-MediumItalic", fontSize);
            return font;
        }

        public static UIFont GetFontMediumWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Medium", fontSize);
            return font;
        }

        public static UIFont GetFontBoldWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Bold", fontSize);
            return font;
        }

        public static UIFont GetFontBlackItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-BlackItalic", fontSize);
            return font;
        }

        public static UIFont GetFontItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-Italic", fontSize);
            return font;
        }

        public static UIFont GetFontThinItalicWithSize(nfloat fontSize)
        {
            //var font = UIFont()
            var font = UIFont.FromName("Roboto-ThinItalic", fontSize);
            return font;
        }

        public static void GetRoundedCornerFromSideOfView(UIView view,UIRectCorner corners)
        {
            //UIBezierPath.FromRoundedRect()
            //UIBezierPath maskPath = UIBezierPath.FromRoundedRect(view.Bounds, UIRectCorner.BottomRight | UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
            //UIBezierPath maskPath = UIBezierPath.FromRoundedRect(view.Bounds, corners, new CoreGraphics.CGSize(5, 5));
            //CAShapeLayer maskLayer = new CAShapeLayer();
            //maskLayer.Frame = view.Bounds;
            //maskLayer.Path = maskPath.CGPath;
            //view.Layer.Mask = maskLayer;
            //return view;


            UIBezierPath maskPath = UIBezierPath.FromRoundedRect(view.Bounds, corners, new CoreGraphics.CGSize(10, 10));
           CAShapeLayer maskLayer = new CAShapeLayer();
            maskLayer.Frame = view.Bounds;
           maskLayer.Path = maskPath.CGPath;
            view.Layer.Mask = maskLayer; 
        }

    }
}
