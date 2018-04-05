using System;
using System.ComponentModel;
using Foundation;
using UIKit;
using Autofac;
using Mobius.Core.ViewModels;
using Plugin.Connectivity.Abstractions;
using Plugin.Connectivity;
using Mobius.iOS.Helpers;

using System.Drawing;
using Mobius.Services;
using System.Linq;
using System.Runtime;

namespace Mobius.iOS.Views
{
	public class BaseViewController<TViewModel> : UIViewController where TViewModel : IViewModel
	{
		private LoadingOverlay loadingOverlay;
		protected RootViewController RootViewController = (UIApplication.SharedApplication.Delegate as AppDelegate).RootViewController;

		protected NavController NavController => RootViewController.NavController;

		public TViewModel ViewModel { get; set; }
		public bool IsIPhone => UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone;

		public IPlatformService platformService;
		private object lockLoad = new object();
		private volatile bool viewLoaded;
		private volatile bool viewModelLoaded;
		private object[] viewModelEventArgs = new object[2];
		public int yPositionLoading = -1;

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:Mobius.iOS.Views.BaseViewController`1"/> is network connected.
		/// </summary>
		/// <value><c>true</c> if is network connected; otherwise, <c>false</c>.</value>
		public bool IsNetworkConnected
		{
			get { return CrossConnectivity.Current.IsConnected; }
		}
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.BaseViewController`1"/> class.
		/// </summary>
		public BaseViewController() : this(null, null) { }

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.BaseViewController`1"/> class.
		/// </summary>
		/// <param name="nibName">Nib name.</param>
		/// <param name="bundle">Bundle.</param>
		/// <param name="leftMenuWhite">If set to <c>true</c> left menu white.</param>
		/// <param name="yPositionLoading">Y position loading.</param>
		/// <param name="param">Parameter.</param>
		public BaseViewController(string nibName, NSBundle bundle, bool leftMenuWhite, int yPositionLoading, params object[] param)
		{
			
			this.yPositionLoading = yPositionLoading;

			using (var scope = AppDelegate.Container.BeginLifetimeScope())
			{
				platformService = scope.Resolve<IPlatformService>();
				platformService.SetOwner(this);
                ViewModel = scope.Resolve<TViewModel>();

				ViewModel.Init(param);
				ViewModel.PropertyChanged += ViewModel_PropertyChanged;
				ViewModel.LoadCompleted += InternalViewModel_LoadCompleted;
				ViewModel.Start(param);
			}
		
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.iOS.Views.BaseViewController`1"/> class.
		/// </summary>
		/// <param name="nibName">Nib name.</param>
		/// <param name="bundle">Bundle.</param>
		/// <param name="param">Parameter.</param>
		public BaseViewController(string nibName, NSBundle bundle, params object[] param) : base(nibName, bundle)
		{
			using (var scope = AppDelegate.Container.BeginLifetimeScope())
			{
				platformService = scope.Resolve<IPlatformService>();
				ViewModel = scope.Resolve<TViewModel>();
				ViewModel.Init(param);
				ViewModel.PropertyChanged += ViewModel_PropertyChanged;
				ViewModel.LoadCompleted += InternalViewModel_LoadCompleted;
				ViewModel.Start(param);
				platformService.SetOwner(this);
			}
		}

		/// <summary>
		/// Views the did load.
		/// </summary>
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();


			this.View.UserInteractionEnabled = true;

			lock (lockLoad)
			{
				if (viewModelLoaded)
				{
					ViewModel_LoadCompleted(viewModelEventArgs[0], (EventArgs)viewModelEventArgs[1]);
				}
				viewLoaded = true;
			}
		}

		/// <summary>
		/// Shows the nav back button.
		/// </summary>
		public void ShowNavBackButton()
		{
			NavigationItem.LeftBarButtonItems = null;
			var img = UIImage.FromBundle("topnavback");
			var uibutton = new UIButton();
			uibutton.SetImage(img, UIControlState.Normal);
			uibutton.Frame = new CoreGraphics.CGRect(0, 0, 25, 25);
			uibutton.TouchUpInside += (sender, e) =>
			{
				//NavController.PopViewController(true);
				this.Dispose(true);
			};
			var backMenuBtn = new UIBarButtonItem(uibutton);
			backMenuBtn.AccessibilityIdentifier = "Back";
			NavigationItem.SetLeftBarButtonItem(backMenuBtn, true);
		}

		/// <summary>
		/// Internals the view model load completed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void InternalViewModel_LoadCompleted(object sender, EventArgs e)
		{
			// Connection change event
			//CrossConnectivity.Current.ConnectivityChanged += ConnectivityChanged;

			lock (lockLoad)
			{
				if (viewLoaded)
				{
					ViewModel_LoadCompleted(sender, e);
				}
				else
				{
					viewModelEventArgs[0] = sender;
					viewModelEventArgs[1] = e;
				}

				viewModelLoaded = true;
			}
		}

		NSObject didenter;
		NSObject willforeground;
		/// <summary>
		/// Views the will appear.
		/// </summary>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		public override void ViewWillAppear(bool animated)
		{
			CrossConnectivity.Current.ConnectivityChanged += ConnectivityChanged;
			ViewModel.ViewModelWillAppear();
			didenter = UIApplication.Notifications.ObserveDidEnterBackground(DidEnterBackground);
			willforeground = UIApplication.Notifications.ObserveWillEnterForeground(WillEnterForeground);
		}

		/// <summary>
		/// Views the will disappear.
		/// </summary>
		/// <param name="animated">If set to <c>true</c> animated.</param>
		public override void ViewWillDisappear(bool animated)
		{
			CrossConnectivity.Current.ConnectivityChanged -= ConnectivityChanged;
			ViewModel.ViewModelWillDisappear();
			if (didenter != null)
				NSNotificationCenter.DefaultCenter.RemoveObserver(didenter);
			if (willforeground != null)
				NSNotificationCenter.DefaultCenter.RemoveObserver(willforeground);
		}

		/// <summary>
		/// Wills the enter foreground.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public virtual void WillEnterForeground(object sender, NSNotificationEventArgs e)
		{
		}

		/// <summary>
		/// Dids the enter background.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public virtual void DidEnterBackground(object sender, NSNotificationEventArgs e)
		{
		}

		/// <summary>
		/// Views the model property changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "IsLoading")
			{
				if (ViewModel.IsLoading)
				{
					//loadingOverlay = new LoadingOverlay(GetLoadingOverlayFrame(), yPositionLoading);
					//base.View.Add(loadingOverlay);
					//View.BringSubviewToFront(loadingOverlay);
				}
				else
				{
					//loadingOverlay.Hide();
					//loadingOverlay = null;
					//UIView.Animate(0.3, () =>
					//{
					//    loadingOverlay.Hide();
					//    loadingOverlay = null;
					//});
				}
			}
		}

		/// <summary>
		/// Navigates to.
		/// </summary>
		/// <param name="view">View.</param>
		/// <param name="animate">If set to <c>true</c> animate.</param>
		/// <param name="clearNavigationStack">If set to <c>true</c> clear navigation stack.</param>
		/// <param name="clearNavigationStackSameType">If set to <c>true</c> clear navigation stack same type.</param>
		public void NavigateTo(UIViewController view, bool animate, bool clearNavigationStack = false, bool clearNavigationStackSameType = true)
		{
			if (clearNavigationStack && NavController.ViewControllers.Length > 1)
			{
				var homeViewController = NavController.ViewControllers[0];
				NavController.ViewControllers = new[] { homeViewController };
			}

			if (clearNavigationStackSameType)
			{
				var nav = NavController.ViewControllers.FirstOrDefault(t => t.GetType() == view.GetType());
				if (nav != null)
				{
					NavController.ViewControllers = NavController.ViewControllers.Where(t => t.GetType() != view.GetType()).ToArray();
				}
			}
			NavController.PushViewController(view, animate);
		}

		/// <summary>
		/// Sets the view as root.
		/// </summary>
		/// <param name="view">View.</param>
		/// <param name="animate">If set to <c>true</c> animate.</param>
		public void SetViewAsRoot(UIViewController view, bool animate)
		{
			this.NavigateTo(view, animate);

			if (NavController.ViewControllers.Length > 0)
			{
				NavController.ViewControllers = new UIViewController[] { view };
			}
		}

		/// <summary>
		/// Gets the type of the previous view controller.
		/// </summary>
		/// <returns>The previous view controller type.</returns>
		public UIViewController GetPreviousViewControllerType()
		{
			var count = NavController.ViewControllers.Count();
			return count > 1 ? NavController.ViewControllers[count - 2] : NavController.ViewControllers[0];
		}

		/// <summary>
		/// Views the model load completed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public virtual void ViewModel_LoadCompleted(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Connectivities the changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public virtual void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
		}

		/// <summary>
		/// Gets the loading overlay frame.
		/// </summary>
		/// <returns>The loading overlay frame.</returns>
		protected virtual CoreGraphics.CGRect GetLoadingOverlayFrame()
		{
			return View.Frame;
		}

		#region Dismiss Keyboard
		/// <summary>
		/// Call it to force dismiss keyboard when background is tapped
		/// </summary>
		public void HandleTapToDismissKeyboard()
		{
			UITapGestureRecognizer gesture = new UITapGestureRecognizer(() => DismissKeyboard());
			View.AddGestureRecognizer(gesture);
		}

		void DismissKeyboard()
		{
			View.EndEditing(true);
		}
		#endregion

		#region Keyboard adjust

		/// <summary>
		/// Set this field to any view inside the scroll view to center this view instead of the current responder
		/// </summary>
		protected UIView ViewToCenterOnKeyboardShown;
		public virtual bool HandlesKeyboardNotifications()
		{
			return false;
		}

		/// <summary>
		/// Registers for keyboard notifications.
		/// </summary>
		protected virtual void RegisterForKeyboardNotifications()
		{
			NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillHideNotification, OnKeyboardNotification);
			NSNotificationCenter.DefaultCenter.AddObserver(UIKeyboard.WillShowNotification, OnKeyboardNotification);
		}

		/// <summary>
		/// Keyboards the get active view.
		/// </summary>
		/// <returns>The get active view.</returns>
		protected virtual UIView KeyboardGetActiveView()
		{
			return View.FindFirstResponder();
		}

		/// <summary>
		/// Ons the keyboard notification.
		/// </summary>
		/// <param name="notification">Notification.</param>
		void OnKeyboardNotification(NSNotification notification)
		{
			if (!IsViewLoaded)
				return;

			//Check if the keyboard is becoming visible
			bool visible = notification.Name == UIKeyboard.WillShowNotification;

			//Start an animation, using values from the keyboard
			UIView.BeginAnimations("AnimateForKeyboard");
			UIView.SetAnimationBeginsFromCurrentState(true);
			UIView.SetAnimationDuration(UIKeyboard.AnimationDurationFromNotification(notification));
			UIView.SetAnimationCurve((UIViewAnimationCurve)UIKeyboard.AnimationCurveFromNotification(notification));

			//Pass the notification, calculating keyboard height, etc.
			//bool landscape = InterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || InterfaceOrientation == UIInterfaceOrientation.LandscapeRight;
			if (visible)
			{
				var keyboardFrame = UIKeyboard.FrameEndFromNotification(notification);
				OnKeyboardChanged(visible, /*landscape ? */keyboardFrame.Height /*: keyboardFrame.Width*/);
			}
			else
			{
				var keyboardFrame = UIKeyboard.FrameBeginFromNotification(notification);
				OnKeyboardChanged(visible, /*landscape ? */keyboardFrame.Height /*: keyboardFrame.Width*/);
			}

			//Commit the animation
			UIView.CommitAnimations();
		}

		/// <summary>
		/// Ons the keyboard changed.
		/// </summary>
		/// <param name="visible">If set to <c>true</c> visible.</param>
		/// <param name="keyboardHeight">Keyboard height.</param>
		protected virtual void OnKeyboardChanged(bool visible, nfloat keyboardHeight)
		{
			var activeView = ViewToCenterOnKeyboardShown ?? KeyboardGetActiveView();
			if (activeView == null)
				return;

			var scrollView = activeView.FindSuperviewOfType(View, typeof(UIScrollView)) as UIScrollView;
			if (scrollView == null)
				return;

			var offset = (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Pad) ? 250 : 100;

			if (!visible)
				RestoreScrollPosition(scrollView);
			else if (this.View.Frame.Height - keyboardHeight - activeView.Frame.Y - activeView.Frame.Height - offset <= 0)
				CenterViewInScroll(activeView, scrollView, keyboardHeight);
		}

		/// <summary>
		/// Centers the view in scroll.
		/// </summary>
		/// <param name="viewToCenter">View to center.</param>
		/// <param name="scrollView">Scroll view.</param>
		/// <param name="keyboardHeight">Keyboard height.</param>
		protected virtual void CenterViewInScroll(UIView viewToCenter, UIScrollView scrollView, nfloat keyboardHeight)
		{
			var contentInsets = new UIEdgeInsets(0.0f, 0.0f, keyboardHeight, 0.0f);
			scrollView.ContentInset = contentInsets;
			scrollView.ScrollIndicatorInsets = contentInsets;

			// Position of the active field relative isnside the scroll view
			RectangleF relativeFrame = (RectangleF)viewToCenter.Superview.ConvertRectToView(viewToCenter.Frame, scrollView);

			bool landscape = InterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || InterfaceOrientation == UIInterfaceOrientation.LandscapeRight;
			var spaceAboveKeyboard = (landscape ? scrollView.Frame.Width : scrollView.Frame.Height) - keyboardHeight;

			// Move the active field to the center of the available space
			var offset = relativeFrame.Y - (spaceAboveKeyboard - viewToCenter.Frame.Height) / 2;
			offset -= 140;
			scrollView.ContentOffset = new PointF(0, (float)offset);
		}

		/// <summary>
		/// Restores the scroll position.
		/// </summary>
		/// <param name="scrollView">Scroll view.</param>
		protected virtual void RestoreScrollPosition(UIScrollView scrollView)
		{
			scrollView.ContentInset = UIEdgeInsets.Zero;
			scrollView.ScrollIndicatorInsets = UIEdgeInsets.Zero;
		}

		#endregion

		#region Next TextField

		/// <summary>
		/// Texts the field should return.
		/// </summary>
		/// <returns><c>true</c>, if field should return was texted, <c>false</c> otherwise.</returns>
		/// <param name="textfield">Textfield.</param>
		protected bool TextFieldShouldReturn(UITextField textfield)
		{
			int nextTag = (int)textfield.Tag + 1;
			UIResponder nextResponder = this.View.ViewWithTag(nextTag);
			if (nextResponder != null)
			{
				nextResponder.BecomeFirstResponder();
				return true;
			}
			textfield.ResignFirstResponder();
			return false;
		}

		#endregion

	}
}