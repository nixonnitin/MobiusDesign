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
    [Register ("DisplayPriceTextCell")]
    partial class DisplayPriceTextCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView DisplayPricetextView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TextDisplayPrice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView UiMainViewDisplayPriceButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DisplayPricetextView != null) {
                DisplayPricetextView.Dispose ();
                DisplayPricetextView = null;
            }

            if (TextDisplayPrice != null) {
                TextDisplayPrice.Dispose ();
                TextDisplayPrice = null;
            }

            if (UiMainViewDisplayPriceButton != null) {
                UiMainViewDisplayPriceButton.Dispose ();
                UiMainViewDisplayPriceButton = null;
            }
        }
    }
}