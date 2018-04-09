using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public class MyReservationsDataSourceDelegate : UITableViewSource
    {
        UITableView table;
        List<string> sections;

        public MyReservationsDataSourceDelegate(UITableView table, List<string> sections)
        {
            this.table = table;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (MyReservationsTableViewCell)tableView.DequeueReusableCell(MyReservationsTableViewCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            cell.MainViewCell.Layer.CornerRadius = 8;
            cell.MainViewCell.Layer.MasksToBounds = true;

            //cell.Layer.ShadowColor = UIColor.DarkGray.CGColor;
            //cell.Layer.ShadowOpacity = 1.0f;
            //cell.Layer.ShadowRadius = 6.0f;
            //cell.Layer.ShadowOffset = new System.Drawing.SizeF(0f, 3f);
            if (indexPath.Section == 0)
            {
                cell.MainViewCellHeightConstraint.Constant = 282;  
            }
            else
            {
                cell.ImageViewHeightConstraint.Constant = 0;
                cell.MainViewCellHeightConstraint.Constant = 160;
                cell.ViewCheckInOut.BackgroundColor = UIColor.White;
                cell.ViewSelectedDate.BackgroundColor = UIColor.White;
                cell.LabelCheckInOut.TextColor = UIColor.LightGray;
                cell.LabelSelectedDate.TextColor = UIColor.FromRGB(42,123,137);
            }
            cell.ImageViewRoomSmall.Hidden = true;
            cell.ViewReservationSummary.Hidden = true;
            return cell;

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 0)
            {
                return 1;
            }
            else
            {
                return 2;
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

    public class MyReservationsDataSourceDelegateCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public MyReservationsDataSourceDelegateCellLayout(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }

       /* public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
            {
                //return (viewSize.Height * (nfloat)0.10);
                return 298;
            }
            else
            {
                // return (viewSize.Height * (nfloat)0.60);
                return 186;
            }
        }*/
    }
}
