using System;

using UIKit;
using System.Collections.Generic;
using Foundation;

namespace Mobius.iOS.Views
{
    public partial class ReservationPerviousStaysViewController : UIViewController
    {
        public ReservationPerviousStaysViewController() : base("ReservationPerviousStaysViewController", null)
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
            TableViewPreviousStaysList.RowHeight = UITableView.AutomaticDimension;
            TableViewPreviousStaysList.EstimatedRowHeight = 365;
            TableViewPreviousStaysList.RegisterNibForCellReuse(UINib.FromName("MyReservationsTableViewCell", NSBundle.MainBundle), "MyReservationsTableViewCell");
            //TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell14", NSBundle.MainBundle), "HomeCell14");
            TableViewPreviousStaysList.Source = new ReservationPerviousStaysDelegateDataSource(TableViewPreviousStaysList);
            TableViewPreviousStaysList.Delegate = new ReservationPerviousStaysDelegateDataSourceCellLayout(TableViewPreviousStaysList, View.Frame.Size);

        }
    }
}

