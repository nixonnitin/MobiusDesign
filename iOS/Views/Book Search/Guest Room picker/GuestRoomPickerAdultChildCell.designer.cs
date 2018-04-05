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
    [Register ("GuestRoomPickerAdultChildCell")]
    partial class GuestRoomPickerAdultChildCell
    {
        [Outlet]
        public UIKit.UIButton ButtonAdultAdd { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonAdultMinus { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonChildAdd { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonChildMinus { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAdult { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAdultAgeLimit { get; set; }


        [Outlet]
        public UIKit.UILabel LabelAdultCount { get; set; }


        [Outlet]
        public UIKit.UILabel LabelChild { get; set; }


        [Outlet]
        public UIKit.UILabel LabelChildAgeLimit { get; set; }


        [Outlet]
        public UIKit.UILabel LabelChildCount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonAdultAdd != null) {
                ButtonAdultAdd.Dispose ();
                ButtonAdultAdd = null;
            }

            if (ButtonAdultMinus != null) {
                ButtonAdultMinus.Dispose ();
                ButtonAdultMinus = null;
            }

            if (ButtonChildAdd != null) {
                ButtonChildAdd.Dispose ();
                ButtonChildAdd = null;
            }

            if (ButtonChildMinus != null) {
                ButtonChildMinus.Dispose ();
                ButtonChildMinus = null;
            }

            if (LabelAdult != null) {
                LabelAdult.Dispose ();
                LabelAdult = null;
            }

            if (LabelAdultAgeLimit != null) {
                LabelAdultAgeLimit.Dispose ();
                LabelAdultAgeLimit = null;
            }

            if (LabelAdultCount != null) {
                LabelAdultCount.Dispose ();
                LabelAdultCount = null;
            }

            if (LabelChild != null) {
                LabelChild.Dispose ();
                LabelChild = null;
            }

            if (LabelChildAgeLimit != null) {
                LabelChildAgeLimit.Dispose ();
                LabelChildAgeLimit = null;
            }

            if (LabelChildCount != null) {
                LabelChildCount.Dispose ();
                LabelChildCount = null;
            }
        }
    }
}