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
    [Register ("CheckoutPostcodeCountryCell")]
    partial class CheckoutPostcodeCountryCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageArrowDown { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageGlobe { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImageMailBox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextFieldPostcode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewMainPostCodeCountry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewPostcode { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageArrowDown != null) {
                ImageArrowDown.Dispose ();
                ImageArrowDown = null;
            }

            if (ImageGlobe != null) {
                ImageGlobe.Dispose ();
                ImageGlobe = null;
            }

            if (ImageMailBox != null) {
                ImageMailBox.Dispose ();
                ImageMailBox = null;
            }

            if (TextFieldCountry != null) {
                TextFieldCountry.Dispose ();
                TextFieldCountry = null;
            }

            if (TextFieldPostcode != null) {
                TextFieldPostcode.Dispose ();
                TextFieldPostcode = null;
            }

            if (ViewCountry != null) {
                ViewCountry.Dispose ();
                ViewCountry = null;
            }

            if (ViewMainPostCodeCountry != null) {
                ViewMainPostCodeCountry.Dispose ();
                ViewMainPostCodeCountry = null;
            }

            if (ViewPostcode != null) {
                ViewPostcode.Dispose ();
                ViewPostcode = null;
            }
        }
    }
}