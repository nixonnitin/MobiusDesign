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
    [Register ("GuestRoomPicker")]
    partial class GuestRoomPicker
    {
        [Outlet]
        public UIKit.UIButton ButtonRoomAdd { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonRoomSub { get; set; }


        [Outlet]
        public UIKit.UILabel LabelNumberOfRooms { get; set; }


        [Outlet]
        public UIKit.UILabel LabelRoom { get; set; }


        [Outlet]
        public UIKit.UITableView TableViewGuestRoom { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonRoomAdd != null) {
                ButtonRoomAdd.Dispose ();
                ButtonRoomAdd = null;
            }

            if (ButtonRoomSub != null) {
                ButtonRoomSub.Dispose ();
                ButtonRoomSub = null;
            }

            if (LabelNumberOfRooms != null) {
                LabelNumberOfRooms.Dispose ();
                LabelNumberOfRooms = null;
            }

            if (LabelRoom != null) {
                LabelRoom.Dispose ();
                LabelRoom = null;
            }

            if (TableViewGuestRoom != null) {
                TableViewGuestRoom.Dispose ();
                TableViewGuestRoom = null;
            }
        }
    }
}