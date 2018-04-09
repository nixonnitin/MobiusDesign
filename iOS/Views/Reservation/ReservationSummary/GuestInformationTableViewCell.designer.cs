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
    [Register ("GuestInformationTableViewCell")]
    partial class GuestInformationTableViewCell
    {
        [Outlet]
        public UIKit.UIButton ButtonEditDetails { get; set; }


        [Outlet]
        public UIKit.UIView ViewGuestInformationCell { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonEditDetails != null) {
                ButtonEditDetails.Dispose ();
                ButtonEditDetails = null;
            }

            if (ViewGuestInformationCell != null) {
                ViewGuestInformationCell.Dispose ();
                ViewGuestInformationCell = null;
            }
        }
    }
}