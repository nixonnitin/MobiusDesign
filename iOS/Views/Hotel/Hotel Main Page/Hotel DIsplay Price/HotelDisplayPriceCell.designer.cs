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
    [Register ("HotelDisplayPriceCell")]
    partial class HotelDisplayPriceCell
    {
        [Outlet]
        public UIKit.UIButton ButtonMoney { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonPoints { get; set; }


        [Outlet]
        public UIKit.UILabel LabelDisplayPRice { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonMoney != null) {
                ButtonMoney.Dispose ();
                ButtonMoney = null;
            }

            if (ButtonPoints != null) {
                ButtonPoints.Dispose ();
                ButtonPoints = null;
            }

            if (LabelDisplayPRice != null) {
                LabelDisplayPRice.Dispose ();
                LabelDisplayPRice = null;
            }
        }
    }
}