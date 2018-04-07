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
    [Register ("HomePopularDestinationsCell")]
    partial class HomePopularDestinationsCell
    {
        [Outlet]
        UIKit.UIImageView DestinationSubImageTop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView DestinationMainImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblCityName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LblRegionName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DestinationMainImage != null) {
                DestinationMainImage.Dispose ();
                DestinationMainImage = null;
            }

            if (DestinationSubImageTop != null) {
                DestinationSubImageTop.Dispose ();
                DestinationSubImageTop = null;
            }

            if (LblCityName != null) {
                LblCityName.Dispose ();
                LblCityName = null;
            }

            if (LblRegionName != null) {
                LblRegionName.Dispose ();
                LblRegionName = null;
            }
        }
    }
}