using System;
using System.Drawing;
using CoreGraphics;
using UIKit;

namespace Mobius.iOS.Helper
{
	public static class UIViewHelper
	{
		/// <summary>
		/// Finds the first responder.
		/// </summary>
		/// <returns>The first responder.</returns>
		/// <param name="view">View.</param>
		public static UIView FindFirstResponder(this UIView view)
		{
			if (view.IsFirstResponder)
			{
				return view;
			}
			foreach (UIView subView in view.Subviews)
			{
				var firstResponder = subView.FindFirstResponder();
				if (firstResponder != null)
					return firstResponder;
			}
			return null;
		}

		/// <summary>
		/// Finds the type of the superview of.
		/// </summary>
		/// <returns>The superview of type.</returns>
		/// <param name="view">View.</param>
		/// <param name="stopAt">Stop at.</param>
		/// <param name="type">Type.</param>
		public static UIView FindSuperviewOfType(this UIView view, UIView stopAt, Type type)
		{
			if (view.Superview != null)
			{
				if (type.IsAssignableFrom(view.Superview.GetType()))
				{
					return view.Superview;
				}

				if (view.Superview != stopAt)
					return view.Superview.FindSuperviewOfType(stopAt, type);
			}

			return null;
		}

        /// <summary>
        /// Gets the colored image.
        /// </summary>
        /// <returns>The colored image.</returns>
        /// <param name="imageName">Image name.</param>
        /// <param name="color">Color.</param>
        public static UIImage GetColoredImage(string imageName, UIColor color)
        {
            UIImage image = UIImage.FromFile(imageName);
            UIImage coloredImage = null;

            UIGraphics.BeginImageContext(image.Size);
            using (CGContext context = UIGraphics.GetCurrentContext())
            {

                context.TranslateCTM(0, image.Size.Height);
                context.ScaleCTM(1.0f, -1.0f);

                var rect = new RectangleF(0, 0, (float)image.Size.Width, (float)image.Size.Height);

                // draw image, (to get transparancy mask)
                context.SetBlendMode(CGBlendMode.Normal);
                context.DrawImage(rect, image.CGImage);

                // draw the color using the sourcein blend mode so its only draw on the non-transparent pixels
                context.SetBlendMode(CGBlendMode.SourceIn);
                context.SetFillColor(color.CGColor);
                context.FillRect(rect);

                coloredImage = UIGraphics.GetImageFromCurrentImageContext();
                UIGraphics.EndImageContext();
            }
            return coloredImage;
        }

        /// <summary>
        /// Sets the shadow.
        /// </summary>
        /// <param name="view">View.</param>
        public static void SetShadow(UIView view, int cornerRadius = 0)
        {
            view.Layer.CornerRadius = cornerRadius;
            view.Layer.ShadowColor = UIColor.Black.CGColor;
            view.Layer.ShadowOpacity = 1.0f;
            view.Layer.ShadowRadius = 5.0f;
            view.Layer.ShadowOffset = new System.Drawing.SizeF(5f, 5f);
        }

        public static void SetShadow(UIView view, int cornerRadius = 0, float shadowOpacity = 1.0f,float shadowRadius = 5.0f,float sizeFWidth = 5.0f, float sizeFHeight = 5.0f)
        {
            view.Layer.CornerRadius = cornerRadius;
            view.Layer.ShadowColor = UIColor.Black.CGColor;
            view.Layer.ShadowOpacity = shadowOpacity;
            view.Layer.ShadowRadius = shadowRadius;

            view.Layer.ShadowOffset = new System.Drawing.SizeF(sizeFWidth, sizeFHeight);
        }

        /// <summary>
        /// Gets the navigation controller.
        /// </summary>
        /// <returns>The navigation controller.</returns>
        public static UINavigationController GetNavigationController()
        {
            return UIApplication.SharedApplication.Windows[0].RootViewController as UINavigationController;
        }

        /// <summary>
        /// Makes as root view controller.
        /// </summary>
        /// <param name="controller">Controller.</param>
        public static void MakeAsRootViewController(UIViewController controller)
        {
            var navController = new UINavigationController(controller);
            AppDelegate objAppDelegate = (AppDelegate)UIApplication.SharedApplication.Delegate;
            objAppDelegate.Window.RootViewController = navController;
        }

        public static void SetViewBorderAndCornerRadiusForTextField(UIView view, float borderWidth = 2,float cornerRadius = 5)
        {
            view.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
            view.Layer.BorderWidth = borderWidth;
            view.Layer.CornerRadius = cornerRadius;
        }
	}

	/// <summary>
	/// UIC olor extensions.
	/// </summary>
	public static class UIColorExtensions
	{
        /// <summary>
        /// Froms the hex string.
        /// </summary>
        /// <returns>The hex string.</returns>
        /// <param name="color">Color.</param>
        /// <param name="hexValue">Hex value.</param>
        /// <param name="alpha">Alpha.</param>
		public static UIColor FromHexString(this UIColor color, string hexValue, float alpha = 1.0f)
		{
			var colorString = hexValue.Replace("#", "");
			if (alpha > 1.0f)
			{
				alpha = 1.0f;
			}
			else if (alpha < 0.0f)
			{
				alpha = 0.0f;
			}

			float red, green, blue;

			switch (colorString.Length)
			{
				case 3: // #RGB
					{
						red = Convert.ToInt32(string.Format("{0}{0}", colorString.Substring(0, 1)), 16) / 255f;
						green = Convert.ToInt32(string.Format("{0}{0}", colorString.Substring(1, 1)), 16) / 255f;
						blue = Convert.ToInt32(string.Format("{0}{0}", colorString.Substring(2, 1)), 16) / 255f;
						return UIColor.FromRGBA(red, green, blue, alpha);
					}
				case 6: // #RRGGBB
					{
						red = Convert.ToInt32(colorString.Substring(0, 2), 16) / 255f;
						green = Convert.ToInt32(colorString.Substring(2, 2), 16) / 255f;
						blue = Convert.ToInt32(colorString.Substring(4, 2), 16) / 255f;
						return UIColor.FromRGBA(red, green, blue, alpha);
					}

				default:
					throw new ArgumentOutOfRangeException(string.Format("Invalid color value {0} is invalid. It should be a hex value of the form #RBG, #RRGGBB", hexValue));

			}
		}
	}
}