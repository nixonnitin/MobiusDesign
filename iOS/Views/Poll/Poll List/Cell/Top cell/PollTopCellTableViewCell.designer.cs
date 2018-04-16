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
	[Register ("PollTopCellTableViewCell")]
	partial class PollTopCellTableViewCell
	{
		[Outlet]
		public UIKit.UIImageView ImageViewDown { get; set; }

		[Outlet]
        public UIKit.UILabel LabelCompletePoll { get; set; }

		[Outlet]
        public UIKit.UILabel LabelPollTitile { get; set; }

		[Outlet]
        public UIKit.UILabel LabeTakePoll { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (LabelPollTitile != null) {
				LabelPollTitile.Dispose ();
				LabelPollTitile = null;
			}

			if (LabelCompletePoll != null) {
				LabelCompletePoll.Dispose ();
				LabelCompletePoll = null;
			}

			if (LabeTakePoll != null) {
				LabeTakePoll.Dispose ();
				LabeTakePoll = null;
			}

			if (ImageViewDown != null) {
				ImageViewDown.Dispose ();
				ImageViewDown = null;
			}
		}
	}
}
