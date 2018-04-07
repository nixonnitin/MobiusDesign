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
    [Register ("RoomNameCell")]
    partial class RoomNameCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRoomName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRoomPrice { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelRoomName != null) {
                LabelRoomName.Dispose ();
                LabelRoomName = null;
            }

            if (LabelRoomPrice != null) {
                LabelRoomPrice.Dispose ();
                LabelRoomPrice = null;
            }
        }
    }
}