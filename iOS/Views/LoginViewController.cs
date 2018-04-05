using System;
using System.Drawing;
using Autofac;
using CoreGraphics;
using Foundation;
using Mobius.Core.ViewModels;
using UIKit;
namespace Mobius.iOS.Views
{
	public partial class LoginViewController : BaseViewController<AccountViewModel>
	{
		public LoginViewController() : base("LoginViewController", null)
		{
            
		}
		/// <summary>
		/// Views the did load.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

            this.NavigationController.NavigationBar.SetBackgroundImage(new UIImage(), UIBarMetrics.Default);

			this.NavigationController.NavigationBar.ShadowImage = new UIImage();
            this.NavigationController.NavigationBar.Translucent = true;

			NavigationItem.Title = "Login";
		}
		/// <summary>
		/// Dids the receive memory warning.
		/// </summary>
		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
		/// <summary>
		/// Views the will appear.
		/// </summary>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		public override void ViewWillAppear(bool animated)
		{
			var titleLabel = new UILabel(new RectangleF(0, 0, 74, 28));
			titleLabel.Text = "Login";

			NavigationItem.TitleView = titleLabel;
		}
	}
}

