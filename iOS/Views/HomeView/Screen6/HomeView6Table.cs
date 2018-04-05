using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class HomeView6Table : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public HomeView6Table(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            if (indexPath.Section == 0)
            {
                var cell = (HomeCell1)tableView.DequeueReusableCell(HomeCell1.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }else 
            {
                var cell = (HomeCell16)tableView.DequeueReusableCell(HomeCell16.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //if (section == 0)
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 1;
            //}

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

    public class HomeView6TableCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public HomeView6TableCellLayout(UITableView tableView, CGSize viewSize)
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
            }else
            {
                return (viewSize.Height * (nfloat)0.15);
            }
        }
    }
}
