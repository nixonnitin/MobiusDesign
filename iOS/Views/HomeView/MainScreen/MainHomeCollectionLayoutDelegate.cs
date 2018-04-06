using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class MainHomeCollectionLayoutDelegate : UICollectionViewDelegateFlowLayout
    {
        UICollectionView collectionView;
        public MainHomeCollectionLayoutDelegate(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            if (collectionView.Tag == 4)
            {
                nfloat mainWidth = collectionView.Frame.Width;
                nfloat cellWidth = mainWidth * (nfloat)0.95;

                nfloat mainHeight = (collectionView.Frame.Height * (nfloat)0.25);
                nfloat cellHeight = mainHeight;

                return new CGSize(cellWidth, cellHeight);
            }
            else
            {
                nfloat mainWidth = collectionView.Frame.Width;
                nfloat cellWidth = mainWidth * (nfloat)0.85;

                nfloat mainHeight = (collectionView.Frame.Height * (nfloat)0.85);
                nfloat cellHeight = mainHeight;

                return new CGSize(cellWidth, cellHeight);
            }
        }
    }
}
