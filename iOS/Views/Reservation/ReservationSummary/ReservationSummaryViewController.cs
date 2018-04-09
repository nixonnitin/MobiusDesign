using System;

using UIKit;
using System.Collections.Generic;
using Foundation;

namespace Mobius.iOS.Views
{
    public partial class ReservationSummaryViewController : UIViewController
    {
        public ReservationSummaryViewController() : base("ReservationSummaryViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
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

        }

        private void initUI()
        {
            TableViewReservationSummary.RowHeight = UITableView.AutomaticDimension;
            TableViewReservationSummary.EstimatedRowHeight = 401;
            TableViewReservationSummary.RegisterNibForCellReuse(UINib.FromName("MyReservationsTableViewCell", NSBundle.MainBundle), "MyReservationsTableViewCell");
            TableViewReservationSummary.RegisterNibForCellReuse(UINib.FromName("EditStayDatesRoomTypeTableViewCell", NSBundle.MainBundle), "EditStayDatesRoomTypeTableViewCell");
            TableViewReservationSummary.RegisterNibForCellReuse(UINib.FromName("BillingInformationTableViewCell", NSBundle.MainBundle), "BillingInformationTableViewCell");
            TableViewReservationSummary.RegisterNibForCellReuse(UINib.FromName("GuestInformationTableViewCell", NSBundle.MainBundle), "GuestInformationTableViewCell");
            TableViewReservationSummary.RegisterNibForCellReuse(UINib.FromName("PriceBreakDownTableViewCell", NSBundle.MainBundle), "PriceBreakDownTableViewCell");
            TableViewReservationSummary.Source = new ReservationSummaryDataSourceDelegate(TableViewReservationSummary);
            //TableViewReservationSummary.Delegate = new ReservationSummaryDataSourceDelegateCellLayout(TableViewReservationSummary, View.Frame.Size);
            //TableViewReservationSummary.ContentSize = new CoreGraphics.CGSize(View.Frame.Size.Width,2000);
        }
    }
}

