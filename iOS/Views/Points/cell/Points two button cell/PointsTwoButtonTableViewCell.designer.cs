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
    [Register ("PointsTwoButtonTableViewCell")]
    partial class PointsTwoButtonTableViewCell
    {
        [Outlet]
        public UIKit.UIButton ButtonOne { get; set; }


        [Outlet]
        public UIKit.UIButton ButtonTwo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonOne != null) {
                ButtonOne.Dispose ();
                ButtonOne = null;
            }

            if (ButtonTwo != null) {
                ButtonTwo.Dispose ();
                ButtonTwo = null;
            }
        }
    }
}