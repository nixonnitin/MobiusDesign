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
    [Register ("PointsDataViewCell")]
    partial class PointsDataViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelPointsData { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LablePointsDataValue { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ViewMainPointsData { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (LabelPointsData != null) {
                LabelPointsData.Dispose ();
                LabelPointsData = null;
            }

            if (LablePointsDataValue != null) {
                LablePointsDataValue.Dispose ();
                LablePointsDataValue = null;
            }

            if (ViewMainPointsData != null) {
                ViewMainPointsData.Dispose ();
                ViewMainPointsData = null;
            }
        }
    }
}