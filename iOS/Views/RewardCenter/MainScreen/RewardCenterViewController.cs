using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using Mobius.iOS.Helper;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class RewardCenterViewController : UIViewController
    {
        List<string> sections;
        //List<string> collectionViewLabels;
        //List<string> collectionViewImages;

        public RewardCenterViewController() : base("RewardCenterViewController", null)
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
            sections = new List<string> { "", "", "" ,"","","",""};
            //collectionViewLabels = new List<string> { "On-Site Parking", "24-Hours Front Desk", "Complimentary Wireless Internet", "Denny's Restaurant" };
            //collectionViewImages = new List<string> { "parking-1", "food-1", "gym", "homeWiFi" };
        }
        private void initUI()
        {
            TableRoomView.RowHeight = UITableView.AutomaticDimension;
            TableRoomView.EstimatedRowHeight = 100;
            TableRoomView.BackgroundColor = MobiusHelper.GetColorLightGraySeperator();


            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RewardCenterMemberHeaderViewCell", NSBundle.MainBundle), "RewardCenterMemberHeaderViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle), "HomeEnhancementsCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("BreakLineViewCell", NSBundle.MainBundle), "BreakLineViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("ImageWithHeadingViewCell", NSBundle.MainBundle), "ImageWithHeadingViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RewardDescriptionWithButtonViewCell", NSBundle.MainBundle), "RewardDescriptionWithButtonViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RewardDescriptionViewCell", NSBundle.MainBundle), "RewardDescriptionViewCell");
            TableRoomView.RegisterNibForCellReuse(UINib.FromName("RewardsTableViewCell", NSBundle.MainBundle), "RewardsTableViewCell");






            TableRoomView.Source = new RewardCenterTableSource(TableRoomView, sections);
            TableRoomView.Delegate = new RewardCenterDelegate(TableRoomView, View.Frame.Size, sections);





        }

       
    }


    public class RewardCenterDelegate : UITableViewDelegate
    {
        UITableView table;
        CGSize viewSize;
        List<string> sections;
        public RewardCenterDelegate(UITableView tableView, CGSize viewSize, List<string> sections)
        {
            this.table = tableView;
            this.viewSize = viewSize;
            this.sections = sections;
        }
        /*
        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            var headerText = sections[(int)section];
            //var headerHeight = 0;


            var headerView = new UIView(new CGRect(0, 0, tableView.Frame.Size.Width, 20));
           

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
    */

    }


}

