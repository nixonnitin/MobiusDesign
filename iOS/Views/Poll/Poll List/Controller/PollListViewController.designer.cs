// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mobius.iOS.Views
{
	[Register ("PollListViewController")]
	partial class PollListViewController
	{
		[Outlet]
		public UIKit.UITableView TableViewPollList { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableViewPollList != null) {
				TableViewPollList.Dispose ();
				TableViewPollList = null;
			}
		}
	}
}
