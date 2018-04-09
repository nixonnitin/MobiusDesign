using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    
    public class ReservationAddRoomTableDataSourceDelegate : UITableViewSource
    {
        UITableView table;
        List<string> roomName;
        List<string> roomAvailability;
        List<string> roomPricing;


        public ReservationAddRoomTableDataSourceDelegate(UITableView table,List<string> roomName,List<string> roomAvailability,List<string> roomPricing)
        {
            this.table = table;
            this.roomName = roomName;
            this.roomAvailability = roomAvailability;
            this.roomPricing = roomPricing;

        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {

            var cell = (ReservationAddRoomTableViewCell)tableView.DequeueReusableCell(ReservationAddRoomTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelRoomName.Text = roomName[(int)indexPath.Row];
                cell.LabelAvailableBeds.Text = roomAvailability[(int)indexPath.Row];
                cell.LabelPrice.Text = roomPricing[(int)indexPath.Row];
                if(indexPath.Row == 0 || indexPath.Row == 1){
                cell.ImageSelectionStatus.Hidden = true;
               }else{
                cell.ImageSelectionStatus.Hidden = false;
               }
 
                return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {

                return roomName.Count ;

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

    public class ReservationAddRoomTableDataSourceDelegateCellLayout : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        public ReservationAddRoomTableDataSourceDelegateCellLayout(UITableView tableView, CGSize viewSize)
        {
            this.table = tableView;
            this.viewSize = viewSize;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {

                return 71;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {   
           // new UIAlertView("Touched", "uiui", null, "OK", null).Show();
            table.ReloadData();
        }
    }
}

