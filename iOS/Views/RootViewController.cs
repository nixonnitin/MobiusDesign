using Autofac;
using Foundation;
using Mobius.iOS.Helpers;
using Mobius.Services;
using UIKit;

namespace Mobius.iOS.Views
{
	public class RootViewController : UIViewController
	{
		
		public NavController NavController { get; set; }
		public bool StatusBarHidden { get; set; }
		public UIStatusBarStyle StatusBarStyle { get; set; } = UIStatusBarStyle.Default;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.RootViewController"/> class.
		/// </summary>
		public RootViewController() : base(null, null)
		{

		}

		/// <summary>
		/// Views the did load.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var platformService = AppDelegate.Container.Resolve<IPlatformService>();

			platformService.SetOwner(this);

			NavController = new NavController();


			NavController.PushViewController(new RegistrationViewController(), false);


			this.View.UserInteractionEnabled = true;


		}

		/// <summary>
		/// Preferses the status bar hidden.
		/// </summary>
		/// <returns><c>true</c>, if status bar hidden was prefersed, <c>false</c> otherwise.</returns>
		public override bool PrefersStatusBarHidden()
		{
			return this.StatusBarHidden;
		}

		/// <summary>
		/// Updates the satus bar.
		/// </summary>
		public void UpdateSatusBar()
		{
			SetNeedsStatusBarAppearanceUpdate();
		}

		/// <summary>
		/// Preferreds the status bar style.
		/// </summary>
		/// <returns>The status bar style.</returns>
		public override UIStatusBarStyle PreferredStatusBarStyle()
		{
			return StatusBarStyle;
		}
	}
}