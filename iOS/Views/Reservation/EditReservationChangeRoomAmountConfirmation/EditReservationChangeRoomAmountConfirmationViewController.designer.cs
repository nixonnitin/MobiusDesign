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
    [Register ("EditReservationChangeRoomAmountConfirmationViewController")]
    partial class EditReservationChangeRoomAmountConfirmationViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonConfirmChangeRoom { get; set; }


        [Outlet]
        public UIKit.UIView EditReservationChangeRoomAmountConfirmationPopUp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonConfirmChangeRoom != null) {
                ButtonConfirmChangeRoom.Dispose ();
                ButtonConfirmChangeRoom = null;
            }

            if (EditReservationChangeRoomAmountConfirmationPopUp != null) {
                EditReservationChangeRoomAmountConfirmationPopUp.Dispose ();
                EditReservationChangeRoomAmountConfirmationPopUp = null;
            }
        }
    }
}