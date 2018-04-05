using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class GuestRoomPicker : UIViewController
    {
        List<string> labels;
        List<string> labelsAgeLimit;

        public GuestRoomPicker() : base("GuestRoomPicker", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //Initalize data
            initData();
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initData()
        {
            labels = new List<string> { "Adults", "Children"};
            labelsAgeLimit = new List<string> { "16+ Years", "1-15 Year" };
        }

        private void initUI()
        {
            TableViewGuestRoom.RowHeight = UITableView.AutomaticDimension;
            TableViewGuestRoom.EstimatedRowHeight = 60;
            TableViewGuestRoom.RegisterNibForCellReuse(UINib.FromName("GuestRoomPickerCancelDoneCell", NSBundle.MainBundle), "GuestRoomPickerCancelDoneCell");
            TableViewGuestRoom.RegisterNibForCellReuse(UINib.FromName("GuestRoomPickerAdultChildCell", NSBundle.MainBundle), "GuestRoomPickerAdultChildCell");
            TableViewGuestRoom.RegisterNibForCellReuse(UINib.FromName("GuestRoomPickerRoomCell", NSBundle.MainBundle), "GuestRoomPickerRoomCell");
            TableViewGuestRoom.Source = new GuestRoomPickerSource(TableViewGuestRoom, labels,labelsAgeLimit);
        }
    }

    public class GuestRoomPickerSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelsAgeLimit;

        public GuestRoomPickerSource(UITableView table, List<string> labels, List<string> labelsAgeLimit)
        {
            this.table = table;
            this.labels = labels;
            this.labelsAgeLimit = labelsAgeLimit;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (GuestRoomPickerCancelDoneCell)tableView.DequeueReusableCell(GuestRoomPickerCancelDoneCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Row == 1)
            {
                var cell = (GuestRoomPickerRoomCell)tableView.DequeueReusableCell(GuestRoomPickerRoomCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else
            {
                var cell = (GuestRoomPickerAdultChildCell)tableView.DequeueReusableCell(GuestRoomPickerAdultChildCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelAdult.Text = "Adults";
                cell.LabelAdultAgeLimit.Text = "16+ Years";

                cell.LabelChild.Text = "Children";
                cell.LabelChildAgeLimit.Text = "1-15 Year";

                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 3;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

    } 
}

