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
    [Register ("PreferencesCell")]
    partial class PreferencesCell
    {
        [Outlet]
        public UIKit.UIImageView ImageViewLast { get; set; }

        [Outlet]
        public UIKit.UILabel LabelData { get; private set; }

        [Outlet]
        public UIKit.UILabel LabelPreferences { get; private set; }

        void ReleaseDesignerOutlets ()
        {
            if (ImageViewLast != null) {
                ImageViewLast.Dispose ();
                ImageViewLast = null;
            }

            if (LabelData != null) {
                LabelData.Dispose ();
                LabelData = null;
            }

            if (LabelPreferences != null) {
                LabelPreferences.Dispose ();
                LabelPreferences = null;
            }
        }
    }
}