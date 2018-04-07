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
    [Register ("HomeCollectionContainerCell")]
    partial class HomeCollectionContainerCell
    {
        [Outlet]
        public UIKit.UICollectionView CollectionViewHomeCell14 { get; private set; }


        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintCollectionViewHeight { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CollectionViewHomeCell14 != null) {
                CollectionViewHomeCell14.Dispose ();
                CollectionViewHomeCell14 = null;
            }

            if (ConstraintCollectionViewHeight != null) {
                ConstraintCollectionViewHeight.Dispose ();
                ConstraintCollectionViewHeight = null;
            }
        }
    }
}