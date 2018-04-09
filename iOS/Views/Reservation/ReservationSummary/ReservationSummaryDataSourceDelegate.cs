using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
namespace Mobius.iOS.Views
{
    public class ReservationSummaryDataSourceDelegate : UITableViewSource
    {
        UITableView table;

        public ReservationSummaryDataSourceDelegate(UITableView table)
        {
            this.table = table;

        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
            {
                var cell = (MyReservationsTableViewCell)tableView.DequeueReusableCell(MyReservationsTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ImageViewHeightConstraint.Constant = 0;
                cell.ButtonBookAgain.Hidden = false;
                cell.MainViewCell.Layer.CornerRadius = 8;
                cell.MainViewCell.Layer.MasksToBounds = true;
                cell.ViewCheckInOut.BackgroundColor = UIColor.White;
                cell.ViewSelectedDate.BackgroundColor = UIColor.White;
                cell.LabelCheckInOut.TextColor = UIColor.Black;
                cell.LabelSelectedDate.TextColor = UIColor.FromRGB(42, 123, 137);
                cell.ViewPrice.BackgroundColor = UIColor.FromRGB(42, 123, 137);
                cell.LabelTotalStay.TextColor = UIColor.White;
                cell.LabelTotalPrice.TextColor = UIColor.White;
                cell.ButtonBookAgain.Layer.CornerRadius = 8;
                cell.ButtonBookAgain.Layer.MasksToBounds = true;
                cell.ImageViewRoomSmall.Hidden = false;
                cell.ViewPrice.Hidden = true;
                cell.ViewReservationSummary.Hidden = false;
                cell.ViewReservationSummary.Layer.CornerRadius = 8;
                cell.ViewReservationSummary.Layer.MasksToBounds = true;
                cell.MainViewCellHeightConstraint.Constant = 220;
                cell.ButtonBookAgain.Hidden = true;

                return cell;
            }else if(indexPath.Section == 1 || indexPath.Section == 2){
                var cell = (EditStayDatesRoomTypeTableViewCell)tableView.DequeueReusableCell(EditStayDatesRoomTypeTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                if(indexPath.Row == 1){
                    cell.LabelEditType.Text = "Edit Stay Dates";  
                    cell.LabelEditValue.Text = "29/8/18 - 4/9/18";
                    cell.LabelSeperator.Hidden = false;
                }else{
                    cell.LabelEditType.Text = "Edit Room Type";
                    cell.LabelEditValue.Text = "Queen Double Deluxe";
                    cell.LabelSeperator.Hidden = true;
                }

                return cell; 
            }else if(indexPath.Section == 3){
                var cell = (GuestInformationTableViewCell)tableView.DequeueReusableCell(GuestInformationTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ViewGuestInformationCell.Layer.CornerRadius = 8;
                cell.ViewGuestInformationCell.Layer.MasksToBounds = true;
                return cell;
            }else if(indexPath.Section == 4){
                var cell = (BillingInformationTableViewCell)tableView.DequeueReusableCell(BillingInformationTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ViewBillingInformation.Layer.CornerRadius = 8;
                cell.ViewBillingInformation.Layer.MasksToBounds = true;
                return cell;
            }else{
                var cell = (PriceBreakDownTableViewCell)tableView.DequeueReusableCell(PriceBreakDownTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ViewPriceBreakDown.Layer.CornerRadius = 8;
                cell.ViewPriceBreakDown.Layer.MasksToBounds = true;
                cell.ButtonCancelReservation.Layer.CornerRadius = 8;
                cell.ButtonCancelReservation.Layer.MasksToBounds = true;
                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {

            return 1;

        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 6;
        }

        //public override string TitleForHeader(UITableView tableView, nint section)
        //{
        //    var titleHeader = sections[(int)section];
        //    return titleHeader;
        //}
    }

    //public class ReservationSummaryDataSourceDelegateCellLayout : UITableViewDelegate
    //{
    //    UITableView table;
    //    CGSize viewSize;
    //    public ReservationSummaryDataSourceDelegateCellLayout(UITableView tableView, CGSize viewSize)
    //    {
    //        this.table = tableView;
    //        this.viewSize = viewSize;
    //    }

    //    //public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
    //    //{
    //    //    /* if (indexPath.Row == 0)
    //    //     {
    //    //         return 236;
    //    //     }
    //    //     else if (indexPath.Row == 1 || indexPath.Row == 2){
    //    //         return 44;

    //    //     }else if(indexPath.Row == 3){
    //    //         return 171;

    //    //     }else if(indexPath.Row == 4){
    //    //         return 171;

    //    //     }else if (indexPath.Row == 5)
    //    //     {
    //    //         return 401;
    //    //     }
    //    //     return 0;*/
    //    //   // return UITableView.AutomaticDimension;
    //    //}


    //    //public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
    //    //{
    //    //    // new UIAlertView("Touched", "uiui", null, "OK", null).Show();
    //    //    tableView.ReloadData();
    //    //    Console.Write("Enter how much money you want {0}",tableView.ContentSize);
    //    //}
    //}
}
