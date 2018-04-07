using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeView2Table : UITableViewSource
    {
        UITableView table;


        public HomeView2Table(UITableView table)
        {
            this.table = table;

        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            
            if (indexPath.Section == 0)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeLastSearchCell)tableView.DequeueReusableCell(HomeLastSearchCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintImageWidth.Constant = 0;
                return cell;
            }
            else
            {
                var cell = (HomeCell15)tableView.DequeueReusableCell(HomeCell15.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 3;
        }

    }

    public class HomeView2TableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeView2TableCellLayout(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }
        //public override GetHeight

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
            {
                return (viewSize.Height * (nfloat)0.10);
            }
            else if (indexPath.Section == 1)
            {
                return (viewSize.Height * (nfloat)0.15);
            }
            else
            {
                return (viewSize.Height * (nfloat)0.45);
            }

        }
    }



    public class HomeView2OfferCellLayout : UICollectionViewDelegateFlowLayout
    {
        UICollectionView collectionView;
        public HomeView2OfferCellLayout(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            nfloat mainWidth = collectionView.Frame.Width;
            nfloat cellWidth = mainWidth * (nfloat)0.85;

            nfloat mainHeight = (collectionView.Frame.Height * (nfloat)0.85);
            nfloat cellHeight = mainHeight;

            return new CGSize(cellWidth, cellHeight);
        }

    }
}
