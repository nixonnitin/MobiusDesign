using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeView5Table : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public HomeView5Table(UITableView table, List<string> sections)
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
            else
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.ConstraintOfferHeight.Constant =
                //cell.ConstraintButtonCheckinHeight.Constant = 0;
                //cell.ConstraintLabelAdvancedPurchaseHeight.Constant = 0;
                cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return 1;
            }
            else
            {
                return 1;
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

    public class HomeView5TableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeView5TableCellLayout(UITableView tableView, CGSize viewSize)
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
            else 
            {
                return (viewSize.Height * (nfloat)0.60);
            }
        }
    }
}
