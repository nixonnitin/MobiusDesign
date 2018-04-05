using System;
using UIKit;

namespace Mobius.iOS.Views
{
	public class NavController : UINavigationController
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.NavController"/> class.
		/// </summary>
		public NavController() : base((string)null, null)
		{

		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.NavController"/> class.
		/// </summary>
		/// <param name="viewController">View controller.</param>
		public NavController(UIViewController viewController) : base(viewController)
		{

		}
		/// <summary>
		/// Views the did load.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
		}
		/// <summary>
		/// Gets the top view controller.
		/// </summary>
		/// <value>The top view controller.</value>
		public UIViewController TopViewController
		{
			get
			{
				return base.TopViewController;
			}
		}
	}
}