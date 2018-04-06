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
    [Register ("MainResultViewController")]
    partial class MainResultViewController
    {
        [Outlet]
        public UIKit.UIButton ButtonDates { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonGuests { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonLocation { get; set; }


        [Outlet]
        public UIKit.UILabel LabelDates { get; set; }


        [Outlet]
        public UIKit.UILabel LabelDatesValue { get; set; }


        [Outlet]
        public UIKit.UILabel LabelGuests { get; set; }


        [Outlet]
        public UIKit.UILabel LabelGuestsValue { get; set; }


        [Outlet]
        public UIKit.UILabel LabelLocation { get; private set; }


        [Outlet]
        UIKit.UILabel LabelLocationValue { get; set; }


        [Outlet]
        public UIKit.UILabel LabelTop { get; private set; }


        [Outlet]
        public UIKit.UITableView TableViewMainResult { get; private set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonDates != null) {
                ButtonDates.Dispose ();
                ButtonDates = null;
            }

            if (ButtonGuests != null) {
                ButtonGuests.Dispose ();
                ButtonGuests = null;
            }

            if (ButtonLocation != null) {
                ButtonLocation.Dispose ();
                ButtonLocation = null;
            }

            if (LabelDates != null) {
                LabelDates.Dispose ();
                LabelDates = null;
            }

            if (LabelDatesValue != null) {
                LabelDatesValue.Dispose ();
                LabelDatesValue = null;
            }

            if (LabelGuests != null) {
                LabelGuests.Dispose ();
                LabelGuests = null;
            }

            if (LabelGuestsValue != null) {
                LabelGuestsValue.Dispose ();
                LabelGuestsValue = null;
            }

            if (LabelLocation != null) {
                LabelLocation.Dispose ();
                LabelLocation = null;
            }

            if (LabelLocationValue != null) {
                LabelLocationValue.Dispose ();
                LabelLocationValue = null;
            }

            if (LabelTop != null) {
                LabelTop.Dispose ();
                LabelTop = null;
            }

            if (TableViewMainResult != null) {
                TableViewMainResult.Dispose ();
                TableViewMainResult = null;
            }
        }
    }
}