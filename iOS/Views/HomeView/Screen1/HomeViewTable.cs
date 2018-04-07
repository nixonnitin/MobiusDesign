using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeViewTable : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public HomeViewTable(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            
            if (indexPath.Section == 0)
            {
                var cell = (HomeIntroductionCell)tableView.DequeueReusableCell(HomeIntroductionCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelText.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.";
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell4", NSBundle.MainBundle), "HomeCell4");
                cell.CollectionViewHomeCell14.Tag = 1;
                cell.CollectionViewHomeCell14.Source = new HomeViewOfferCell(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new HomeViewOfferCellLayout(cell.CollectionViewHomeCell14); 
                return cell;
            }else if (indexPath.Section == 3)
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell2", NSBundle.MainBundle), "HomeCell2");
                cell.CollectionViewHomeCell14.Tag = 2;
                cell.CollectionViewHomeCell14.Source = new HomeViewOfferCell(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new HomeViewOfferCellLayout(cell.CollectionViewHomeCell14);
                return cell;
            }else 
            {
                var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell6", NSBundle.MainBundle), "HomeCell6");
                cell.CollectionViewHomeCell14.Tag = 3;
                cell.CollectionViewHomeCell14.Source = new HomeViewOfferCell(cell.CollectionViewHomeCell14);
                cell.CollectionViewHomeCell14.Delegate = new HomeViewOfferCellLayout(cell.CollectionViewHomeCell14);
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

    public class HomeViewOfferCell : UICollectionViewSource
    {
        UICollectionView collectionView;

        public HomeViewOfferCell(UICollectionView collectionView)
        {
            this.collectionView = collectionView;
        }

        public override nint NumberOfSections(UICollectionView collectionView)
        {
            return 1;
        }

        public override UICollectionViewCell GetCell(UICollectionView collectionView, NSIndexPath indexPath)
        {
            if(collectionView.Tag == 1){
                var cell = (HomeCell4)collectionView.DequeueReusableCell(HomeCell4.Key, indexPath);
                return cell;
            }else if (collectionView.Tag == 2)
            {
                var cell = (HomeCell2)collectionView.DequeueReusableCell(HomeCell2.Key, indexPath);
                return cell;

            }else{
                var cell = (HomeCell6)collectionView.DequeueReusableCell(HomeCell6.Key, indexPath);
                return cell;
            }
        }

        public override nint GetItemsCount(UICollectionView collectionView, nint section)
        {
            return 10;
        }
    }


    public class HomeViewTableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeViewTableCellLayout(UITableView tableView,CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
            if(indexPath.Section == 0){
                return (viewSize.Height * (nfloat)0.20);
            }else if(indexPath.Section == 1){
                return (viewSize.Height * (nfloat)0.10);
            }else if (indexPath.Section == 2)
            {
                return (viewSize.Height * (nfloat)0.25);
            }else if (indexPath.Section == 3)
            {

                return (viewSize.Height * (nfloat)0.45);
            }else 
            {
                return (viewSize.Height * (nfloat)0.35);
            }
		}
	}



    public class HomeViewOfferCellLayout : UICollectionViewDelegateFlowLayout
    {
        UICollectionView collectionView;
        public HomeViewOfferCellLayout(UICollectionView collectionView)
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
