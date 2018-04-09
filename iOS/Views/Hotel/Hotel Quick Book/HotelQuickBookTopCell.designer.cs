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
    [Register ("HotelQuickBookTopCell")]
    partial class HotelQuickBookTopCell
    {
        [Outlet]
        public UIKit.UILabel LabelBookOnlineGetBestPrice { get; set; }


        [Outlet]
        public UIKit.UILabel LabelQuickCheckout { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelBookOnlineGetBestPrice != null) {
                LabelBookOnlineGetBestPrice.Dispose ();
                LabelBookOnlineGetBestPrice = null;
            }

            if (LabelQuickCheckout != null) {
                LabelQuickCheckout.Dispose ();
                LabelQuickCheckout = null;
            }
        }
    }
}