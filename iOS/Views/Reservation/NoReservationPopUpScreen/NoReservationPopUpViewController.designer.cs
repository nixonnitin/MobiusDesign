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
    [Register ("NoReservationPopUpViewController")]
    partial class NoReservationPopUpViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonBookYourStay { get; set; }


        [Outlet]
        public UIKit.UIView NoReservationAlertPopUp { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonBookYourStay != null) {
                ButtonBookYourStay.Dispose ();
                ButtonBookYourStay = null;
            }

            if (NoReservationAlertPopUp != null) {
                NoReservationAlertPopUp.Dispose ();
                NoReservationAlertPopUp = null;
            }
        }
    }
}