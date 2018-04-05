using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    public partial class HomeViewControllerScreen2 : UIViewController
    {
        public HomeViewControllerScreen2() : base("HomeViewControllerScreen2", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewHome.RowHeight = UITableView.AutomaticDimension;
            TableViewHome.EstimatedRowHeight = 64;
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell1", NSBundle.MainBundle), "HomeCell1");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell7", NSBundle.MainBundle), "HomeCell7");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell15", NSBundle.MainBundle), "HomeCell15");
            TableViewHome.Source = new HomeView2Table(TableViewHome);

            TableViewHome.Delegate = new HomeView2TableCellLayout(TableViewHome, View.Frame.Size);


        }
    }
}

