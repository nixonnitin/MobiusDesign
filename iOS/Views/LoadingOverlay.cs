using CoreGraphics;
using System;
using UIKit;

namespace Mobius.iOS.Views
{
	public sealed class LoadingOverlay : UIView
	{
		// control declarations
		private readonly UIActivityIndicatorView activitySpinner;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.LoadingOverlay"/> class.
		/// </summary>
		/// <param name="frame">Frame.</param>
		/// <param name="yPositionLoading">Y position loading.</param>
		public LoadingOverlay(CGRect frame, int yPositionLoading = -1) : base(frame)
		{
			// configurable bits
			BackgroundColor = UIColor.White;// UIColor.Black;
											//  Alpha = 0.75f;
			AutoresizingMask = UIViewAutoresizing.All;

			if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad)
			{
				Frame = UIDevice.CurrentDevice.Orientation == UIDeviceOrientation.Portrait ?
					new CGRect(Frame.X, yPositionLoading != -1 ? yPositionLoading : 88, Frame.Width, Frame.Height) :
					new CGRect(Frame.X, yPositionLoading != -1 ? yPositionLoading : 118, Frame.Width, Frame.Height);
			}
			else
			{
				Frame = UIDevice.CurrentDevice.Orientation == UIDeviceOrientation.Portrait
					? new CGRect(Frame.X, yPositionLoading != -1 ? yPositionLoading : 60, Frame.Width, Frame.Height)
					: new CGRect(Frame.X, yPositionLoading != -1 ? yPositionLoading : 64, Frame.Width, Frame.Height);
			}

			nfloat labelHeight = 22;
			nfloat labelWidth = Frame.Width - 10;

			// derive the center x and y
			nfloat centerX = Frame.Width / 2;
			nfloat centerY = Frame.Height / 2;

			// create the activity spinner, center it horizontall and put it 5 points above center x
			activitySpinner = new UIActivityIndicatorView(UIActivityIndicatorViewStyle.Gray);
			activitySpinner.AccessibilityIdentifier = "IsLoading";

			activitySpinner.Frame = new CGRect(
				centerX - (activitySpinner.Frame.Width / 2),
				centerY - activitySpinner.Frame.Height - 20,
				activitySpinner.Frame.Width,
				activitySpinner.Frame.Height);
			activitySpinner.AutoresizingMask = UIViewAutoresizing.All;
			AddSubview(activitySpinner);
			activitySpinner.StartAnimating();

			// create and configure the "Loading Data" label
			var loadingLabel = new UILabel(new CGRect(
				centerX - (labelWidth / 2),
				centerY + 10,
				labelWidth,
				labelHeight
			))
			{
				BackgroundColor = UIColor.Clear,
				MinimumFontSize = 10,
				TextColor = UIColor.Gray,
				Text = "Loading Data...",
				TextAlignment = UITextAlignment.Center,
				AutoresizingMask = UIViewAutoresizing.All
			};
			//AddSubview(loadingLabel);   
		}

		/// <summary>
		/// Fades out the control and then removes it from the super view
		/// </summary>
		public void Hide()
		{
			Animate(
				0.5, // duration
				() => { Alpha = 0; },
				() => { RemoveFromSuperview(); }
			);
		}
	}
}