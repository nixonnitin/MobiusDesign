using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    public partial class HomeViewControllerScreen3 : UIViewController
    {
        List<string> sections;
        public HomeViewControllerScreen3() : base("HomeViewControllerScreen3", null)
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
            sections = new List<string> {"","","Selected Offers:" };
        }

        private void initUI()
        {
            TableViewHome.RowHeight = UITableView.AutomaticDimension;
            TableViewHome.EstimatedRowHeight = 64;
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell1", NSBundle.MainBundle), "HomeCell1");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell7", NSBundle.MainBundle), "HomeCell7");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell14", NSBundle.MainBundle), "HomeCell14");
            TableViewHome.Source = new HomeView3Table(TableViewHome,sections);

            TableViewHome.Delegate = new HomeView3TableCellLayout(TableViewHome, View.Frame.Size);


        }
    }
}

