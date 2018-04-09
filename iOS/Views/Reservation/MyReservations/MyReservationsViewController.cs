using System;

using UIKit;
using System.Collections.Generic;
using Foundation;

namespace Mobius.iOS.Views
{
    public partial class MyReservationsViewController : UIViewController
    {
        List<string> sections;
        public MyReservationsViewController() : base("MyReservationsViewController", null)
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
            sections = new List<string> { "Your Next Stay:", "Your Future Stays:" };
        }

        private void initUI()
        {
            TableViewMyReservations.RowHeight = UITableView.AutomaticDimension;
            TableViewMyReservations.EstimatedRowHeight = 298;
            TableViewMyReservations.RegisterNibForCellReuse(UINib.FromName("MyReservationsTableViewCell", NSBundle.MainBundle), "MyReservationsTableViewCell");
            //TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell14", NSBundle.MainBundle), "HomeCell14");
            TableViewMyReservations.Source = new MyReservationsDataSourceDelegate(TableViewMyReservations, sections);
            TableViewMyReservations.Delegate = new MyReservationsDataSourceDelegateCellLayout(TableViewMyReservations, View.Frame.Size);


        }
    }
}

