using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    public partial class HomeViewControllerScreen4 : UIViewController
    {
        List<string> sections;
        public HomeViewControllerScreen4() : base("HomeViewControllerScreen4", null)
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
            sections = new List<string> { "", "Your Up Coming Stay:", "Your Purchased Enhancements:", "Recommended Enhancements:" };
        }

        private void initUI()
        {
            TableViewHome.RowHeight = UITableView.AutomaticDimension;
            TableViewHome.EstimatedRowHeight = 64;
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell1", NSBundle.MainBundle), "HomeCell1");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell10", NSBundle.MainBundle), "HomeCell10");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell13", NSBundle.MainBundle), "HomeCell13");
            //TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell14", NSBundle.MainBundle), "HomeCell14");
            TableViewHome.Source = new HomeView4Table(TableViewHome, sections);

            TableViewHome.Delegate = new HomeView4TableCellLayout(TableViewHome, View.Frame.Size);


        }
    }
}

