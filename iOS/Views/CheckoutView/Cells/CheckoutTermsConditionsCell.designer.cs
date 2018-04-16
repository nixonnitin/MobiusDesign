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
    [Register ("CheckoutTermsConditionsCell")]
    partial class CheckoutTermsConditionsCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIButton ButtonCheckbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel LabelAgree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UILabel LabelTerms { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        public UIKit.UIView ViewContainer { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ButtonCheckbox != null) {
                ButtonCheckbox.Dispose ();
                ButtonCheckbox = null;
            }

            if (LabelAgree != null) {
                LabelAgree.Dispose ();
                LabelAgree = null;
            }

            if (LabelTerms != null) {
                LabelTerms.Dispose ();
                LabelTerms = null;
            }

            if (ViewContainer != null) {
                ViewContainer.Dispose ();
                ViewContainer = null;
            }
        }
    }
}