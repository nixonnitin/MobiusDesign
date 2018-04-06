﻿using System;
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
                cell.BookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                //cell.BookYourStay.Layer.BorderWidth = 1;
                //cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.BookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (HomeCell13)tableView.DequeueReusableCell(HomeCell13.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintOfferHeight.Constant = 0;
                return cell;
            }
            else if (indexPath.Section == 2)
            {
                var cell = (HomeCell16)tableView.DequeueReusableCell(HomeCell16.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 3)
            {
                var cell = (HomeCell10)tableView.DequeueReusableCell(HomeCell10.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ConstraintSelectedViewWidth.Constant = 0;
                cell.LabelPointsDetail.Hidden = true;
                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (HomeCell11)tableView.DequeueReusableCell(HomeCell11.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section == 5)
            {
                var cell = (HomeCell1)tableView.DequeueReusableCell(HomeCell1.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.ConstraintSelectedViewWidth.Constant = 0;
                //cell.LabelPointsDetail.Hidden = true;
                cell.BookYourStay.BackgroundColor = UIColor.White;
                cell.BookYourStay.Layer.BorderWidth = 1;
                cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
//                self.yourView.layer.borderWidth = 1
//self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.BookYourStay.SetTitleColor(new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f), UIControlState.Normal);
                return cell;
            }
            else
            {
                var cell = (HomeCell15)tableView.DequeueReusableCell(HomeCell15.Key, indexPath);
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
