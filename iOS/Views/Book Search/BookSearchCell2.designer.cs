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
    [Register ("BookSearchCell2")]
    partial class BookSearchCell2
    {
        [Outlet]
        public UIKit.UIImageView ImageView1 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageView2 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageViewArrow { get; set; }


        [Outlet]
        public UIKit.UILabel LabelError { get; set; }


        [Outlet]
        public UIKit.UILabel LabelTop { get; set; }


        [Outlet]
        public UIKit.UITextField TextField1 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageView1 != null) {
                ImageView1.Dispose ();
                ImageView1 = null;
            }

            if (ImageView2 != null) {
                ImageView2.Dispose ();
                ImageView2 = null;
            }

            if (ImageViewArrow != null) {
                ImageViewArrow.Dispose ();
                ImageViewArrow = null;
            }

            if (LabelError != null) {
                LabelError.Dispose ();
                LabelError = null;
            }

            if (LabelTop != null) {
                LabelTop.Dispose ();
                LabelTop = null;
            }

            if (TextField1 != null) {
                TextField1.Dispose ();
                TextField1 = null;
            }
        }
    }
}