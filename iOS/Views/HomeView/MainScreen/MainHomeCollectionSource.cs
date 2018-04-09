using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using CoreAnimation;
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
                cell.ConstraintOfferHeight.Constant = 24;
                    return cell;
                }
                else if (collectionView.Tag == 2)
                {
                    var cell = (HomeNearHotelCell)collectionView.DequeueReusableCell(HomeNearHotelCell.Key, indexPath);
                //UIBezierPath maskPath = UIBezierPath.FromRoundedRect(cell.LabelOuterLayout.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(5, 5));
                //CAShapeLayer maskLayer = new CAShapeLayer();
                //maskLayer.Frame = cell.LabelOuterLayout.Bounds;
                //maskLayer.Path = maskPath.CGPath;
                //cell.LabelOuterLayout.Layer.Mask = maskLayer;


                //UIBezierPath maskPathImage = UIBezierPath.FromRoundedRect(cell.HotelImage.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
                //CAShapeLayer maskLayerImage = new CAShapeLayer();
                //maskLayerImage.Frame = cell.HotelImage.Bounds;
                //maskLayerImage.Path = maskPathImage.CGPath;
                //cell.HotelImage.Layer.Mask = maskLayerImage;
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
                        cell.ConstraintOfferHeight.Constant = 24;
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
