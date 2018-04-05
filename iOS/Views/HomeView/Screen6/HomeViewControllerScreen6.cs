using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    public partial class HomeViewControllerScreen6 : UIViewController
    {
        List<string> sections;
        public HomeViewControllerScreen6() : base("HomeViewControllerScreen6", null)
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
            sections = new List<string> { "", "Your Reservation:" ,""};
        }

        private void initUI()
        {
            TableViewHome.RowHeight = UITableView.AutomaticDimension;
            TableViewHome.EstimatedRowHeight = 64;
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell1", NSBundle.MainBundle), "HomeCell1");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell13", NSBundle.MainBundle), "HomeCell13");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell16", NSBundle.MainBundle), "HomeCell16");
            TableViewHome.Source = new HomeView5Table(TableViewHome, sections);

            TableViewHome.Delegate = new HomeView5TableCellLayout(TableViewHome, View.Frame.Size);


        }

    }
}

