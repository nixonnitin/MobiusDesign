using System;
using System.ComponentModel;

namespace Mobius.Core.ViewModels
{
	public interface IViewModel
	{		
		bool IsLoading { get; set; }
		bool IsNetworkConnected { get; }
		void Start(params object[] param);
		void ViewModelWillAppear();
		void ViewModelWillDisappear();
		void Init(params object[] param);
		event EventHandler LoadCompleted;
		event PropertyChangedEventHandler PropertyChanged;
	}
}