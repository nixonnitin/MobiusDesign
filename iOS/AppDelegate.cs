using Foundation;
using UIKit;
using Mobius.iOS.Views;
using Autofac;
using Mobius.Services;
using Mobius.Core;
using Mobius.Data;
using Mobius.Core.ViewModels;
using ObjCRuntime;
using System.IO;

namespace Mobius.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		public RootViewController RootViewController => Window.RootViewController as RootViewController;
		public static IContainer Container { get; set; }

		public override UIWindow Window
		{
			get;
			set;
		}

		/// <summary>
		/// Finisheds the launching.
		/// </summary>
		/// <returns><c>true</c>, if launching was finisheded, <c>false</c> otherwise.</returns>
		/// <param name="application">Application.</param>
		/// <param name="launchOptions">Launch options.</param>
		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			var builder = new ContainerBuilder();
			builder.RegisterType<HttpService>().As<IHttpService>();
			builder.RegisterType<PlatformService>().As<IPlatformService>().SingleInstance();
			builder.RegisterType<AccountService>().As<IAccountService>();

			builder.RegisterType<AccountViewModel>().SingleInstance();

			Container = builder.Build();

            //            for family in UIFont.familyNames.sorted() {
            //                let names = UIFont.fontNames(forFamilyName: family)
            //    print("Family: \(family) Font names: \(names)")
            //}
            //foreach (string family in UIFont.FamilyNames){
            //    //System.Console.WriteLine(family);
            //    //            let names = UIFont.fontNames(forFamilyName: family)
            //    //print("Family: \(family) Font names: \(names)")
            //    var names = UIFont.FontNamesForFamilyName(family);

            //    foreach (string fontname in names)
            //    {
            //        System.Console.WriteLine("Family:" + family + " Font names:" + fontname);
            //    }
            //}

            //var controller = new Views.RegistrationViewController();
            //var controller = new Views.MenuViewController();
            //var controller = new Views.HomeViewController();
            //var controller = new Views.HomeViewControllerScreen2();
            //var controller = new Views.HomeViewControllerScreen3();
            //var controller = new Views.HomeViewControllerScreen4();
            //var controller = new Views.HomeViewControllerScreen5();
            //var controller = new Views.HomeViewControllerScreen6();
            //var controller = new Views.MainHomeViewController();
            //var controller = new Views.RoomViewController();
            //var controller = new Views.BuyEnhancementViewController();
            var controller = new Views.RewardCenterViewController();




            //var controller = new Views.ReservationViewController();
            //var controller = new Views.TestViewController();
           // var controller = new Views.CheckoutViewController();
            //var controller = new Views.OffersViewController();
            //var controller = new Views.MainResultViewController();
            //var controller = new Views.BookSearch();
            //var controller = new Views.CheckoutViewController();
			var navController = new UINavigationController(controller);

			Window.RootViewController = navController;

            // make the window visible
            Window.MakeKeyAndVisible();

			return true;
		}

		/// <summary>
		/// Ons the resign activation.
		/// </summary>
		/// <param name="application">Application.</param>
		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		/// <summary>
		/// Dids the enter background.
		/// </summary>
		/// <param name="application">Application.</param>
		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		/// <summary>
		/// Wills the enter foreground.
		/// </summary>
		/// <param name="application">Application.</param>
		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		/// <summary>
		/// Ons the activated.
		/// </summary>
		/// <param name="application">Application.</param>
		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		/// <summary>
		/// Wills the terminate.
		/// </summary>
		/// <param name="application">Application.</param>
		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}
	}
}

