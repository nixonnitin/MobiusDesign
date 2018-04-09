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
        public UIKit.UICollectionView CollectionViewHomeCell { get; private set; }


        [Outlet]
        public UIKit.NSLayoutConstraint ConstraintCollectionViewHeight { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CollectionViewHomeCell != null) {
                CollectionViewHomeCell.Dispose ();
                CollectionViewHomeCell = null;
            }

            if (ConstraintCollectionViewHeight != null) {
                ConstraintCollectionViewHeight.Dispose ();
                ConstraintCollectionViewHeight = null;
            }
        }
    }
}