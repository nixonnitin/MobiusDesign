// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
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
            if (ImageViewDown != null) {
                ImageViewDown.Dispose ();
                ImageViewDown = null;
            }

            if (LabelCompletePoll != null) {
                LabelCompletePoll.Dispose ();
                LabelCompletePoll = null;
            }

            if (LabelPollTitile != null) {
                LabelPollTitile.Dispose ();
                LabelPollTitile = null;
            }

            if (LabeTakePoll != null) {
                LabeTakePoll.Dispose ();
                LabeTakePoll = null;
            }
        }
    }
}