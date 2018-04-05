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
    [Register ("BookSearchCell1")]
    partial class BookSearchCell1
    {
        [Outlet]
        public UIKit.UIImageView ImageView1 { get; set; }


        [Outlet]
        public UIKit.UIImageView ImageView2 { get; set; }


        [Outlet]
        public UIKit.UILabel lbl1 { get; private set; }


        [Outlet]
        public UIKit.UILabel lbl2 { get; private set; }

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

            if (lbl1 != null) {
                lbl1.Dispose ();
                lbl1 = null;
            }

            if (lbl2 != null) {
                lbl2.Dispose ();
                lbl2 = null;
            }
        }
    }
}