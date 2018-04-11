using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HotelCollectionViewDelegate  : UICollectionViewDelegateFlowLayout
    {
        UICollectionView collectionView;
        public HotelCollectionViewDelegate(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }

        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            
                nfloat mainWidth = collectionView.Frame.Width;
                nfloat cellWidth = mainWidth * (nfloat)0.25;

                nfloat mainHeight = (collectionView.Frame.Height * (nfloat)0.50);
                nfloat cellHeight = mainHeight;

                return new CGSize(cellWidth, cellHeight);

        }
    }
}
