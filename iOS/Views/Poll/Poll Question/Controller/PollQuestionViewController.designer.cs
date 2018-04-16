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
	[Register ("PollQuestionViewController")]
	partial class PollQuestionViewController
	{
		[Outlet]
		public UIKit.UITableView TableViewPollQuestion { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TableViewPollQuestion != null) {
				TableViewPollQuestion.Dispose ();
				TableViewPollQuestion = null;
			}
		}
	}
}
