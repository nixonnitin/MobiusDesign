using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BuyEnhancementViewController : UIViewController
    {
        List<string> sections;
        //List<string> collectionViewLabels;
        //List<string> collectionViewImages;

        public BuyEnhancementViewController() : base("BuyEnhancementViewController", null)
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
            sections = new List<string> { "Your Next Stay:", "Your Future Stays:", "Recommended Enhancement:","Your Purchased Enhancements:","","",""};
            //collectionViewLabels = new List<string> { "On-Site Parking", "24-Hours Front Desk", "Complimentary Wireless Internet", "Denny's Restaurant" };
            //collectionViewImages = new List<string> { "parking-1", "food-1", "gym", "homeWiFi" };
        }
        private void initUI()
        {
            TableRoomView.RowHeight = UITableView.AutomaticDimension;
            TableRoomView.EstimatedRowHeight = 100;
            TableRoomView.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();

            TableRoomView.RegisterNibForCellReuse(UINib.FromName("HomeRateCell", NSBundle.MainBundle), "HomeRateCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle), "HomeEnhancementsCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("HomeNotificationCell", NSBundle.MainBundle), "HomeNotificationCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("BreakfastViewCell", NSBundle.MainBundle), "BreakfastViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("SearchAmentiesButtonViewCell", NSBundle.MainBundle), "SearchAmentiesButtonViewCell");







            TableRoomView.Source = new BuyEnhancementTableSource(TableRoomView, sections);
            TableRoomView.Delegate = new BuyEnhancementDelegate(TableRoomView, View.Frame.Size, sections);





        }
    }


    public class BuyEnhancementDelegate : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        List<string> sections;
        public BuyEnhancementDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
        {
            this.table = tableView;
            this.viewSize = viewSize;
            this.sections = sections;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
           var headerText = sections[(int)section];
            //var headerHeight = 0;


            var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, 20));
            /*if (headerText == "")
            {
                headerView.BackgroundColor = UIColor.Red;
            }
            else
            {
                headerView.BackgroundColor = UIColor.Green;
            }
            */
            
            var headerLabel = new UILabel(new CGRect(5, 2, tableView.Frame.Size.Width - 5, 20));
            headerLabel.BackgroundColor = UIColor.Clear;
            headerLabel.TextColor = UIColor.Black;
            headerLabel.Font = UIFont.BoldSystemFontOfSize(16);

            headerLabel.Text = headerText;
            headerLabel.TextAlignment = UITextAlignment.Left;
            //headerLabel.Center.Y = headerView.Center.Y;
            headerView.AddSubview(headerLabel);

            return headerView;

        }

    }


}

