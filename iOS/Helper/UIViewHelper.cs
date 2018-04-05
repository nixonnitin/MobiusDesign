using System;
using UIKit;

namespace Mobius.iOS.Helpers
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
	}

	/// <summary>
	/// UIC olor extensions.
	/// </summary>
	public static class UIColorExtensions
	{
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