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
    [Register ("GuestRoomPickerCancelDoneCell")]
    partial class GuestRoomPickerCancelDoneCell
    {
        [Outlet]
        public UIKit.UIButton ButtonGuestRoomPickerApply { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonGuestRoomPickerCancel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonGuestRoomPickerApply != null) {
                ButtonGuestRoomPickerApply.Dispose ();
                ButtonGuestRoomPickerApply = null;
            }

            if (ButtonGuestRoomPickerCancel != null) {
                ButtonGuestRoomPickerCancel.Dispose ();
                ButtonGuestRoomPickerCancel = null;
            }
        }
    }
}