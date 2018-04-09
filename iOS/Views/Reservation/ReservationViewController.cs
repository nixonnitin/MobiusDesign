using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public partial class ReservationViewController : UIViewController
    {
        List<string> roomName;
        List<string> roomAvailability;
        List<string> roomPricing;
        public ReservationViewController() : base("ReservationViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
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
            roomName = new List<string> { "Queen Double Deluxe Suite", "King Suite Deluxe","Family Suite"};
            roomAvailability = new List<string> { "1 Bed guaranteed", "2 Bed guaranteed:","3 Bed guaranteed" };
            roomPricing = new List<string> { "$73.00 Per Night", "$120.00 Per Night","$240.00 Per Night" };
        }

        private void initUI()
        {
            TableViewReservation.RowHeight = UITableView.AutomaticDimension;
            TableViewReservation.EstimatedRowHeight = 71;
            TableViewReservation.RegisterNibForCellReuse(UINib.FromName("ReservationAddRoomTableViewCell", NSBundle.MainBundle), "ReservationAddRoomTableViewCell");
            TableViewReservation.Source = new ReservationAddRoomTableDataSourceDelegate(TableViewReservation,roomName,roomAvailability,roomPricing);

            TableViewReservation.Delegate = new ReservationAddRoomTableDataSourceDelegateCellLayout(TableViewReservation, View.Frame.Size);
            ButtonConfirmUpdates.Layer.CornerRadius = 6;
            ButtonConfirmUpdates.Layer.MasksToBounds = true;

        }
    }
}

