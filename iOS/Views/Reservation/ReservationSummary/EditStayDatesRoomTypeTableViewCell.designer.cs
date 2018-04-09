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
    [Register ("EditStayDatesRoomTypeTableViewCell")]
    partial class EditStayDatesRoomTypeTableViewCell
    {
        [Outlet]
        public UIKit.UILabel LabelEditType { get; private set; }


        [Outlet]
        public UIKit.UILabel LabelEditValue { get; private set; }


        [Outlet]
        public UIKit.UILabel LabelSeperator { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelEditType != null) {
                LabelEditType.Dispose ();
                LabelEditType = null;
            }

            if (LabelEditValue != null) {
                LabelEditValue.Dispose ();
                LabelEditValue = null;
            }

            if (LabelSeperator != null) {
                LabelSeperator.Dispose ();
                LabelSeperator = null;
            }
        }
    }
}