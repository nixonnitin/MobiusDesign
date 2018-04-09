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
    [Register ("ReservationAddRoomTableViewCell")]
    partial class ReservationAddRoomTableViewCell
    {
        [Outlet]
        public UIKit.UIImageView ImageSelectionStatus { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAvailableBeds { get; set; }


        [Outlet]
        public UIKit.UILabel LabelPrice { get; set; }


        [Outlet]
        public UIKit.UILabel LabelRoomName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageSelectionStatus != null) {
                ImageSelectionStatus.Dispose ();
                ImageSelectionStatus = null;
            }

            if (LabelAvailableBeds != null) {
                LabelAvailableBeds.Dispose ();
                LabelAvailableBeds = null;
            }

            if (LabelPrice != null) {
                LabelPrice.Dispose ();
                LabelPrice = null;
            }

            if (LabelRoomName != null) {
                LabelRoomName.Dispose ();
                LabelRoomName = null;
            }
        }
    }
}