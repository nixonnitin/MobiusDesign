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
    [Register ("MenuExistingUserCell1")]
    partial class MenuExistingUserCell1
    {
        [Outlet]
        public UIKit.UIImageView imgArrow { get; set; }


        [Outlet]
        public UIKit.UIImageView imgIcon { get; set; }


        [Outlet]
        public UIKit.UILabel lblName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblName != null) {
                lblName.Dispose ();
                lblName = null;
            }
        }
    }
}