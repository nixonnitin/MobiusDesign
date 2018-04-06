// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Mobius.iOS.Views
{
	[Register ("HomeCell14")]
	partial class HomeCell14
	{
		[Outlet]
		public UIKit.UICollectionView CollectionViewHomeCell14 { get; private set; }

		[Outlet]
		public UIKit.NSLayoutConstraint ConstraintCollectionViewHeight { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ConstraintCollectionViewHeight != null) {
				ConstraintCollectionViewHeight.Dispose ();
				ConstraintCollectionViewHeight = null;
			}

			if (CollectionViewHomeCell14 != null) {
				CollectionViewHomeCell14.Dispose ();
				CollectionViewHomeCell14 = null;
			}
		}
	}
}
