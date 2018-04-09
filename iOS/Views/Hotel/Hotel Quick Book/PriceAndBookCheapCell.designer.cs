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
    [Register ("PriceAndBookCheapCell")]
    partial class PriceAndBookCheapCell
    {
        [Outlet]
        UIKit.UIImageView ImageViewNext { get; set; }


        [Outlet]
        public UIKit.UILabel LabelBookCheapest { get; private set; }


        [Outlet]
        public UIKit.UILabel LabelCancellableOrNoRooms { get; private set; }


        [Outlet]
        public UIKit.UILabel LabelPrice { get; private set; }


        [Outlet]
        public UIKit.UIView ViewMain { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewNext != null) {
                ImageViewNext.Dispose ();
                ImageViewNext = null;
            }

            if (LabelBookCheapest != null) {
                LabelBookCheapest.Dispose ();
                LabelBookCheapest = null;
            }

            if (LabelCancellableOrNoRooms != null) {
                LabelCancellableOrNoRooms.Dispose ();
                LabelCancellableOrNoRooms = null;
            }

            if (LabelPrice != null) {
                LabelPrice.Dispose ();
                LabelPrice = null;
            }

            if (ViewMain != null) {
                ViewMain.Dispose ();
                ViewMain = null;
            }
        }
    }
}