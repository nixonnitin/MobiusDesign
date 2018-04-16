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
    [Register ("OfferPageWebviewCell")]
    partial class OfferPageWebviewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.NSLayoutConstraint ConstraintWebviewHeight { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIWebView WebviewDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ConstraintWebviewHeight != null) {
                ConstraintWebviewHeight.Dispose ();
                ConstraintWebviewHeight = null;
            }

            if (WebviewDescription != null) {
                WebviewDescription.Dispose ();
                WebviewDescription = null;
            }
        }
    }
}