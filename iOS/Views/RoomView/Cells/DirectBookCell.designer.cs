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
    [Register ("DirectBookCell")]
    partial class DirectBookCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView UIMainView_DirectBook { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView UIView_DirectBook { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView UiView_Price { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (UIMainView_DirectBook != null) {
                UIMainView_DirectBook.Dispose ();
                UIMainView_DirectBook = null;
            }

            if (UIView_DirectBook != null) {
                UIView_DirectBook.Dispose ();
                UIView_DirectBook = null;
            }

            if (UiView_Price != null) {
                UiView_Price.Dispose ();
                UiView_Price = null;
            }
        }
    }
}