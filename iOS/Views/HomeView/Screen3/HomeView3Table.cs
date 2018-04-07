using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeView3Table : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public HomeView3Table(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
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
                return cell;
            }
            else
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell4", NSBundle.MainBundle), "HomeCell4");
                cell.CollectionViewHomeCell14.Tag = 1;
                var layout = new UICollectionViewFlowLayout();
                layout.ScrollDirection = UICollectionViewScrollDirection.Vertical;
                cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
                cell.CollectionViewHomeCell14.Source = new HomeViewOffer3Cell(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new HomeViewOffer3CellLayout(cell.CollectionViewHomeCell14);
                //cell.CollectionViewHomeCell14.scrol
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return sections.Count;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            var titleHeader = sections[(int)section];
            return titleHeader;
        }
    }

    public class HomeViewOffer3Cell : UICollectionViewSource
    {
        UICollectionView collectionView;

        public HomeViewOffer3Cell(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
                var cell = (HomeOfferCellSmall)collectionView.DequeueReusableCell(HomeOfferCellSmall.Key, indexPath);
            if(indexPath.Row % 2 == 0){
                cell.ConstraintOfferHeight.Constant = 25;
            }else{
                cell.ConstraintOfferHeight.Constant = 0;
            }
                return cell;
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 10;
        }
    }


    public class HomeView3TableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeView3TableCellLayout(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }

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
                return (viewSize.Height * (nfloat)0.75);
            }
        }
    }



    public class HomeViewOffer3CellLayout : UICollectionViewDelegateFlowLayout
    {
        UICollectionView collectionView;
        public HomeViewOffer3CellLayout(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }
        public override CGSize GetSizeForItem(UICollectionView collectionView, UICollectionViewLayout layout, NSIndexPath indexPath)
        {
            nfloat mainWidth = collectionView.Frame.Width;
            nfloat cellWidth = mainWidth * (nfloat)0.95;

            nfloat mainHeight = (collectionView.Frame.Height * (nfloat)0.25);
            nfloat cellHeight = mainHeight;

            return new CGSize(cellWidth, cellHeight);
        }

    }
}
