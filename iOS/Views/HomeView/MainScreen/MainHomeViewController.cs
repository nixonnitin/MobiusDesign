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
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeOfferCellLarge", NSBundle.MainBundle), "HomeOfferCellLarge");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle), "HomeEnhancementsCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeRateCell", NSBundle.MainBundle), "HomeRateCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeWidgetCell", NSBundle.MainBundle), "HomeWidgetCell");
            TableViewHome.RegisterNibForCellReuse(UINib.FromName("HomeNotificationCell", NSBundle.MainBundle), "HomeNotificationCell");
            TableViewHome.Source = new MainHomeTableSource(TableViewHome, sections);
            TableViewHome.Delegate = new MainHomeTableDelegate(TableViewHome, View.Frame.Size,sections);
        }
    }
}

