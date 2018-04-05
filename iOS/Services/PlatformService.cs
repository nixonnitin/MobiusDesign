using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


using UIKit;

using CoreGraphics;
using Foundation;
using ObjCRuntime;
//using Mobius.Core.Helpers;
using Mobius.iOS.Helpers;
using Mobius.iOS.Views;

//using Mobius.iOS.Views.OfflineDialog;
using Mobius.Services;

using System.Collections.Generic;

namespace Mobius.Services
{
	public class PlatformService : IPlatformService
	{
		private UIViewController viewController;
		/// <summary>
		/// Gets the version.
		/// </summary>
		/// <value>The version.</value>
		public string Version
		{
			get
			{
				return NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
			}
		}

		/// <summary>
		/// Gets the owner.
		/// </summary>
		/// <value>The owner.</value>
		public object Owner
		{
			get
			{
				return this.viewController;
			}
		}


		/// <summary>
		/// Gets a value indicating whether this <see cref="T:Mobius.Services.PlatformService"/> is android.
		/// </summary>
		/// <value><c>true</c> if is android; otherwise, <c>false</c>.</value>
		public bool IsAndroid
		{
			get
			{
				return false;
			}
		}
		/// <summary>
		/// Sets the owner.
		/// </summary>
		/// <param name="owner">Owner.</param>
		public void SetOwner(object owner)
		{
			this.viewController = (UIViewController)owner;
		}
		/// <summary>
		/// Notifies the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		/// <param name="okText">Ok text.</param>
		/// <param name="completionHandler">Completion handler.</param>
		public Task<bool> NotifyAsync(string title, string message, string okText, Action completionHandler = null)
		{
			//return Task.Run(() =>
			//	{
			viewController.InvokeOnMainThread(delegate
				{
					var okAlertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);

					okAlertController.AddAction(UIAlertAction.Create(okText, UIAlertActionStyle.Default, (a) =>
					{
						completionHandler?.Invoke();
					}));

					if (UIApplication.SharedApplication.KeyWindow.RootViewController.PresentedViewController != null)
					{
						UIApplication.SharedApplication.KeyWindow.RootViewController.PresentedViewController.PresentViewController(okAlertController, true, null);
					}
					else
					{
						UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(okAlertController, true, null);
					}
				});
			return Task.FromResult(true);
			//});
		}
		/// <summary>
		/// Confirms the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		/// <param name="yesText">Yes text.</param>
		/// <param name="noText">No text.</param>
		/// <param name="callback">Callback.</param>
		public Task<bool> ConfirmAsync(string title, string message, string yesText, string noText, Action<bool> callback)
		{
			return Task.Run(() =>
				{
					viewController.InvokeOnMainThread(delegate
						{
							var confirmAlertController = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
							confirmAlertController.AddAction(UIAlertAction.Create(yesText, UIAlertActionStyle.Cancel, (UIAlertAction obj) => callback.Invoke(true)));
							confirmAlertController.AddAction(UIAlertAction.Create(noText, UIAlertActionStyle.Default, (UIAlertAction obj) => callback.Invoke(false)));
							viewController.PresentViewController(confirmAlertController, true, null);
						});
					return true;
				});
		}
		/// <summary>
		/// Log the specified ex, memberName and sourceLineNumber.
		/// </summary>
		/// <returns>The log.</returns>
		/// <param name="ex">Ex.</param>
		/// <param name="memberName">Member name.</param>
		/// <param name="sourceLineNumber">Source line number.</param>
		public void Log(Exception ex, [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0)
		{
			Debug.WriteLine($"CallerName: {memberName}");
			Debug.WriteLine($"LineNumber: {sourceLineNumber}");
			Debug.WriteLine($"Ex Message: {ex.Message}");
			Debug.WriteLine($"Ex Stack Trace: {ex.StackTrace}");


		}
		/// <summary>
		/// Log the specified errorMsg, memberName and sourceLineNumber.
		/// </summary>
		/// <returns>The log.</returns>
		/// <param name="errorMsg">Error message.</param>
		/// <param name="memberName">Member name.</param>
		/// <param name="sourceLineNumber">Source line number.</param>
		public void Log(string errorMsg, [CallerMemberName] string memberName = "", [CallerLineNumber] int sourceLineNumber = 0)
		{
			Debug.WriteLine($"CallerName: {memberName}");
			Debug.WriteLine($"LineNumber: {sourceLineNumber}");
			Debug.WriteLine($"Ex Message: {errorMsg}");


		}
		/// <summary>
		/// Notifies the connection lost.
		/// </summary>
		public void NotifyConnectionLost()
		{
			viewController.InvokeOnMainThread(() =>
			{

				//Show Alert

			});


	  }


		/// <summary>
		/// Creates the symbolic link folder.
		/// </summary>
		/// <param name="path">Path.</param>
		/// <param name="destinationPath">Destination path.</param>
		public void CreateSymbolicLinkFolder(string path, string destinationPath)
		{
			NSError error = null;
			NSFileManager.DefaultManager.Remove(path, out error);
			var success = NSFileManager.DefaultManager.CreateSymbolicLink(NSUrl.CreateFileUrl(path, null), NSUrl.CreateFileUrl(destinationPath, null), out error);
			if (error != null || !success)
			{
				Console.WriteLine("Error on CreateSymbolicLinkFolder, {0}", error.Code);
			}
		}
	}
}