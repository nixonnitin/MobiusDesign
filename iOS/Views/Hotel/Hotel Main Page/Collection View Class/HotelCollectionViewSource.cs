using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using CoreAnimation;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public class HotelCollectionViewSource : UICollectionViewSource
    {
        List<string> labels;
        List<string> images;
        UICollectionView collectionView;

        public HotelCollectionViewSource(UICollectionView collectionView, List<string> labels, List<string> images)
        {
            this.collectionView = collectionView;
            this.labels = labels;
            this.images = images;
        }

            public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            var cell = (HotelAmenitiesCollectionCell)collectionView.DequeueReusableCell(HotelAmenitiesCollectionCell.Key, indexPath);

            //Amenities
            cell.LabelAmenities.Text = labels[indexPath.Row];
            cell.LabelAmenities.Font = MobiusHelper.GetFontRegularWithSize(10);
            cell.LabelAmenities.TextColor = UIColor.Black;

            cell.ImageViewAmenities.Image = UIImage.FromBundle(images[indexPath.Row]);
            return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return labels.Count;
        }
    }
}
