using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class ReservationPerviousStaysDelegateDataSource : UITableViewSource
    {
        UITableView table;
 


        public ReservationPerviousStaysDelegateDataSource(UITableView table)
        {
            this.table = table;
 
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            var cell = (MyReservationsTableViewCell)tableView.DequeueReusableCell(MyReservationsTableViewCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            cell.ButtonBookAgain.Hidden = false;
            cell.MainViewCell.Layer.CornerRadius = 8;
            cell.MainViewCell.Layer.MasksToBounds = true;
            cell.ViewCheckInOut.BackgroundColor = UIColor.White;
            cell.ViewSelectedDate.BackgroundColor = UIColor.White;
            cell.LabelCheckInOut.TextColor = UIColor.LightGray;
            cell.LabelSelectedDate.TextColor = UIColor.FromRGB(42, 123, 137);
            cell.ViewPrice.BackgroundColor = UIColor.FromRGB(42, 123, 137);
            cell.LabelTotalStay.TextColor = UIColor.White;
            cell.LabelTotalPrice.TextColor = UIColor.White;
            cell.ButtonBookAgain.Layer.CornerRadius = 8;
            cell.ButtonBookAgain.Layer.MasksToBounds = true;
            cell.ImageViewRoomSmall.Hidden = true;
            cell.ViewReservationSummary.Hidden = true;
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {

            return 4;

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        //public override string TitleForHeader(UITableView tableView, nint section)
        //{
        //    var titleHeader = sections[(int)section];
        //    return titleHeader;
        //}
    }

    public class ReservationPerviousStaysDelegateDataSourceCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public ReservationPerviousStaysDelegateDataSourceCellLayout(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }

        //public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        //{

        //    return 365;
        //}

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            // new UIAlertView("Touched", "uiui", null, "OK", null).Show();
            table.ReloadData();
        }
    }
}
