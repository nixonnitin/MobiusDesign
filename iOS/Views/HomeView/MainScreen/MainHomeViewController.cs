using System;

using UIKit;
using System.Collections.Generic;
using Foundation;
namespace Mobius.iOS.Views
{
    public partial class MainHomeViewController : UIViewController
    {
        List<string> sections;
        public MainHomeViewController() : base("MainHomeViewController", null)
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
            sections = new List<string> { "", "", "Offers", "Hotels Near You", "Popular Destinations","","", "", 
                "Selected Offers:", "Your Up Coming Stay:", "Your Purchased Enhancements:", "Recommended Enhancements:", "Your Reservation:", "Your Reservation:" ,"","Select your welcome benefit:","","","" };
        }

        private void initUI()
        {
            TableViewHome.RowHeight = UITableView.AutomaticDimension;
            TableViewHome.EstimatedRowHeight = 100;
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeIntroductionCell", NSBundle.MainBundle), "HomeIntroductionCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeButtonCell", NSBundle.MainBundle), "HomeButtonCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCollectionContainerCell", NSBundle.MainBundle), "HomeCollectionContainerCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeLastSearchCell", NSBundle.MainBundle), "HomeLastSearchCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell15", NSBundle.MainBundle), "HomeCell15");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell10", NSBundle.MainBundle), "HomeCell10");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell13", NSBundle.MainBundle), "HomeCell13");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell16", NSBundle.MainBundle), "HomeCell16");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeCell11", NSBundle.MainBundle), "HomeCell11");
            TableViewHome.Source = new MainHomeTableSource(TableViewHome, sections);
            TableViewHome.Delegate = new MainHomeTableDelegate(TableViewHome, View.Frame.Size,sections);
        }
    }
}

