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
    [Register ("RoomDescriptionCell")]
    partial class RoomDescriptionCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButtionReadMoreRoomDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRoomDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LableRoomDescrHeading { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtionReadMoreRoomDescription != null) {
                ButtionReadMoreRoomDescription.Dispose ();
                ButtionReadMoreRoomDescription = null;
            }

            if (LabelRoomDescription != null) {
                LabelRoomDescription.Dispose ();
                LabelRoomDescription = null;
            }

            if (LableRoomDescrHeading != null) {
                LableRoomDescrHeading.Dispose ();
                LableRoomDescrHeading = null;
            }
        }
    }
}