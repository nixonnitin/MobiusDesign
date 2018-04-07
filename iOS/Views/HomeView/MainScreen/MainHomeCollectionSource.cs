using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
        public class MainHomeCollectionSource : UICollectionViewSource
        {
            UICollectionView collectionView;

            public MainHomeCollectionSource(UICollectionView collectionView)
            {
                this.collectionView = collectionView;
            }

            public override nint NumberOfSections(UICollectionView collectionView)
            {
                return 1;
            }

            public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
            {
                if (collectionView.Tag == 1)
                {
                    var cell = (HomeOfferCellSmall)collectionView.DequeueReusableCell(HomeOfferCellSmall.Key, indexPath);
                cell.ConstraintOfferHeight.Constant = 25;
                    return cell;
                }
                else if (collectionView.Tag == 2)
                {
                    var cell = (HomeNearHotelCell)collectionView.DequeueReusableCell(HomeNearHotelCell.Key, indexPath);
                    return cell;

                }
                else if (collectionView.Tag == 3)
                {
                    var cell = (HomePopularDestinationsCell)collectionView.DequeueReusableCell(HomePopularDestinationsCell.Key, indexPath);
                    return cell;
                }
                else// if (collectionView.Tag == 4)
                {
                    var cell = (HomeOfferCellSmall)collectionView.DequeueReusableCell(HomeOfferCellSmall.Key, indexPath);
                    if (indexPath.Row % 2 == 0)
                    {
                        cell.ConstraintOfferHeight.Constant = 25;
                    }
                    else
                    {
                        cell.ConstraintOfferHeight.Constant = 0;
                    }
                    return cell;
                }
            }

            public override nint GetItemsCount(UICollectionView collectionView, nint section)
            {
                return 10;
            }
        }

}
