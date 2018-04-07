using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeView4Table : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public HomeView4Table(UITableView table, List<string> sections)
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
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                cell.ConstraintButtonCheckinHeight.Constant = 0;
                cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 85;
                return cell;
            }
            else 
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                return cell;
            }
            //else
            //{
            //    var cell = (HomeCell14)tableView.DequeueReusableCell(HomeCell14.Key, indexPath);
            //    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //    cell.CollectionViewHomeCell14.RegisterNibForCell(UINib.FromName("HomeCell4", NSBundle.MainBundle), "HomeCell4");
            //    cell.CollectionViewHomeCell14.Tag = 1;
            //    var layout = new UICollectionViewFlowLayout();
            //    layout.ScrollDirection = UICollectionViewScrollDirection.Vertical;
            //    cell.CollectionViewHomeCell14.CollectionViewLayout = layout;
            //    cell.CollectionViewHomeCell14.Source = new HomeViewOffer3Cell(cell.CollectionViewHomeCell14);
            //    cell.CollectionViewHomeCell14.Delegate = new HomeViewOffer3CellLayout(cell.CollectionViewHomeCell14);
            //    //cell.CollectionViewHomeCell14.scrol
            //    return cell;
            //}

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if(section == 0){
                return 1;
            }else if(section == 1){
                return 1;
            }else{
                return 3;
            }

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

    public class HomeView4TableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeView4TableCellLayout(UITableView tableView, CGSize viewSize)
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
                return (viewSize.Height * (nfloat)0.60);
            }
            else
            {
                return (viewSize.Height * (nfloat)0.15);
            }
        }
    }
}
