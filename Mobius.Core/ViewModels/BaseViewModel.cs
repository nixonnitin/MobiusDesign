using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Mobius.Services;

namespace Mobius.Core.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged, IViewModel
	{
		protected IPlatformService platformService;

		public BaseViewModel()
		{
			// Connection change event
			//CrossConnectivity.Current.ConnectivityChanged += ConnectivityChanged;
		}


		/// <summary>
		/// Initializes a new instance of the <see cref="T:Mobius.Core.ViewModels.BaseViewModel"/> class.
		/// </summary>
		/// <param name="platformService">Platform service.</param>
		public BaseViewModel(IPlatformService platformService)
		{
			this.platformService = platformService;
		}

		/// <summary>
		/// Gets a value indicating whether this <see cref="T:Mobius.Core.ViewModels.BaseViewModel"/> is network connected.
		/// </summary>
		/// <value><c>true</c> if is network connected; otherwise, <c>false</c>.</value>
		public bool IsNetworkConnected
		{
			get { return CrossConnectivity.Current.IsConnected; }
		}

		/// <summary>
		/// The title.
		/// </summary>
		private string title = string.Empty;
		/// <summary>
		/// Gets or sets the title.
		/// </summary>
		/// <value>The title.</value>
		public string Title
		{
			get { return this.title; }
			set { SetProperty(ref title, value); }
		}

		/// <summary>
		/// The is loading.
		/// </summary>
		private bool _isLoading;
		/// <summary>
		/// Gets or sets a value indicating whether this <see cref="T:Mobius.Core.ViewModels.BaseViewModel"/> is loading.
		/// </summary>
		/// <value><c>true</c> if is loading; otherwise, <c>false</c>.</value>
		public bool IsLoading
		{
			get { return _isLoading; }
			set { SetProperty(ref _isLoading, value); }
		}
		/// <summary>
		/// Init the specified param.
		/// </summary>
		/// <returns>The init.</returns>
		/// <param name="param">Parameter.</param>
		public virtual void Init(params object[] param)
		{
		}
		/// <summary>
		/// Start the specified param.
		/// </summary>
		/// <returns>The start.</returns>
		/// <param name="param">Parameter.</param>
		public virtual void Start(params object[] param)
		{
			NotifyLoadCompleted(param);
		}
		/// <summary>
		/// Occurs when property changed.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;
		public event EventHandler LoadCompleted;
		/// <summary>
		/// Notifies the load completed.
		/// </summary>
		/// <param name="o">O.</param>
		protected void NotifyLoadCompleted(object o)
		{
			this.LoadCompleted?.Invoke(o, null);
		}
		/// <summary>
		/// Sets the property.
		/// </summary>
		/// <returns><c>true</c>, if property was set, <c>false</c> otherwise.</returns>
		/// <param name="storage">Storage.</param>
		/// <param name="value">Value.</param>
		/// <param name="propertyName">Property name.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
		{
			if (object.Equals(storage, value))
			{
				return false;
			}

			storage = value;
			this.OnPropertyChanged(propertyName);
			return true;
		}
		/// <summary>
		/// Ons the property changed.
		/// </summary>
		/// <param name="propertyName">Property name.</param>
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var eventHandler = this.PropertyChanged;
			if (eventHandler == null) return;
			try
			{
				eventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
			catch (Exception ex)
			{
				platformService.Log(ex);
			}
		}

		/// <summary>
		/// Connectivities the changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
			if (!IsNetworkConnected && platformService != null)
			{
				platformService.NotifyConnectionLost();
			}
			ViewModel_ConnectivityChanged(sender, e);
		}
		/// <summary>
		/// Views the model connectivity changed.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		public virtual void ViewModel_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
			if (!e.IsConnected)
			{
				//await platformService.NotifyAsync("No internet connection", "Please, check your internet connection", "Ok", null);
			}
		}
		/// <summary>
		/// Notifies the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		/// <param name="okMessage">Ok message.</param>
		/// <param name="completionHandler">Completion handler.</param>
		public Task NotifyAsync(string title, string message, string okMessage = null, Action completionHandler = null)
		{
			return Task.Run(async () =>
			{
				await platformService.NotifyAsync(title, message, okMessage ?? "Ok", completionHandler);
			});
		}


		/// <summary>
		/// Confirms the async.
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="title">Title.</param>
		/// <param name="message">Message.</param>
		/// <param name="callback">Callback.</param>
		/// <param name="yesText">Yes text.</param>
		/// <param name="noText">No text.</param>
		public async Task ConfirmAsync(string title, string message, Action<bool> callback, string yesText = null, string noText = null)
		{
			await platformService.ConfirmAsync(title, message, yesText ?? "Yes", noText ?? "No", callback);
		}
		/// <summary>
		/// Views the model will appear.
		/// </summary>
		public virtual void ViewModelWillAppear()
		{
			CrossConnectivity.Current.ConnectivityChanged += ConnectivityChanged;
		}
		/// <summary>
		/// Views the model will disappear.
		/// </summary>
		public virtual void ViewModelWillDisappear()
		{
			CrossConnectivity.Current.ConnectivityChanged -= ConnectivityChanged;
		}
		/// <summary>
		/// Ises the network exception.
		/// </summary>
		/// <returns><c>true</c>, if network exception was ised, <c>false</c> otherwise.</returns>
		/// <param name="ex">Ex.</param>
		public static bool IsNetworkException(Exception ex)
		{
			return ex.Message == "!CrossConnectivity.Current.IsConnected" || ex is System.Net.WebException;
		}
	}
}