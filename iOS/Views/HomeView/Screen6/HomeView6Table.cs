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
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.bookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                //cell.BookYourStay.Layer.BorderWidth = 1;
                //cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.bookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeRateCell)tableView.DequeueReusableCell(HomeRateCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeWidgetCell)tableView.DequeueReusableCell(HomeWidgetCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 3)
            {
                var cell = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = true;
                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (HomeNotificationCell)tableView.DequeueReusableCell(HomeNotificationCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 5)
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.LabelPointsDetail.Hidden = true;
                cell.bookYourStay.BackgroundColor = UIColor.White;
                cell.bookYourStay.Layer.BorderWidth = 1;
                cell.bookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
//                self.yourView.layer.borderWidth = 1
//self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.bookYourStay.SetTitleColor(new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f), UIControlState.Normal);
                return cell;
            }
            else
            {
                var cell = (HomeOfferCellLarge)tableView.DequeueReusableCell(HomeOfferCellLarge.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintImageHeight.Constant = 0;
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
            if (section == 3)
            {
                return 3;
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
            tableView.BackgroundColor = UIColor.Clear;
            //tableView.TableHeaderView.BackgroundColor = UIColor.Clear;
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
            if (indexPath.Section == 0 || indexPath.Section == 5)
            {
                return (viewSize.Height * (nfloat)0.10);
            }
            else if (indexPath.Section == 1)
            {
                return (viewSize.Height * (nfloat)0.60);
            }
            else if (indexPath.Section == 4)
            {
                return (viewSize.Height * (nfloat)0.40);
            }else if (indexPath.Section == 6)
            {
                return (viewSize.Height * (nfloat)0.20);
            }else
            {
                return (viewSize.Height * (nfloat)0.15);
            }
        }
    }
}
