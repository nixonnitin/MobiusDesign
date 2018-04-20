using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
using CoreAnimation;

namespace Mobius.iOS.Views
{
    public partial class PointsViewController : UIViewController
    {
        List<string> labels;

        public PointsViewController() : base("PointsViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Double Suite", "Queen Double Deluxe", "Grand King Suite", "Family Triple Suite" };
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewPoints.RowHeight = UITableView.AutomaticDimension;
            TableViewPoints.EstimatedRowHeight = 111;
            TableViewPoints.BackgroundColor = UIColor.FromRGB(225,225,225);
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("BreakLineViewCell", NSBundle.MainBundle), "BreakLineViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("RewardCenterMemberHeaderViewCell", NSBundle.MainBundle), "RewardCenterMemberHeaderViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("PointsTwoLabelTableViewCell", NSBundle.MainBundle), "PointsTwoLabelTableViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("PointsTwoButtonTableViewCell", NSBundle.MainBundle), "PointsTwoButtonTableViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("RewardsTableViewCell", NSBundle.MainBundle), "RewardsTableViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("PollPopupTableViewCell", NSBundle.MainBundle), "PollPopupTableViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("PointsTwoLabelRoundedCellTableViewCell", NSBundle.MainBundle), "PointsTwoLabelRoundedCellTableViewCell");
            TableViewPoints.RegisterNibForCellReuse(UINib.FromName("PointsEarningHistoryTableViewCell", NSBundle.MainBundle), "PointsEarningHistoryTableViewCell");



            TableViewPoints.Source = new TableViewPointsDataSource(TableViewPoints, labels);

        }
    }

    public class TableViewPointsDataSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;

        public TableViewPointsDataSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            switch (indexPath.Row)
            {
                case 0:
                    var cell = (RewardCenterMemberHeaderViewCell)tableView.DequeueReusableCell(RewardCenterMemberHeaderViewCell.Key, indexPath);
                    cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                    //Cell background colour
                    cell.BackgroundColor = UIColor.Clear;
                    //cell.ViewMain.BackgroundColor = UIColor.Clear;

                    return cell;

                case 1:
                    var cell1 = (BreakLineViewCell)tableView.DequeueReusableCell(BreakLineViewCell.Key, indexPath);
                    cell1.SelectionStyle = UITableViewCellSelectionStyle.None;

                    //cell1.ViewMain.BackgroundColor = UIColor.Clear;

                    //Cell background colour
                    cell1.BackgroundColor = UIColor.Clear;

                    return cell1;

                case 2:
                    
                    var cell2 = (PointsTwoLabelTableViewCell)tableView.DequeueReusableCell(PointsTwoLabelTableViewCell.Key, indexPath);
                    cell2.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell2.LabelYourLedger.Text = "Your Points Ledger";
                    cell2.LabelYourLedger.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                    cell2.LabelYourLedger.TextColor = UIColor.Black;

                    cell2.LabelPoints.Text = "650 Points";
                    cell2.LabelPoints.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                    cell2.LabelPoints.TextColor = UIColor.Black;

                    //Cell background colour
                    cell2.BackgroundColor = UIColor.Clear;

                    return cell2;

                case 3:

                    var cell3 = (PointsTwoButtonTableViewCell)tableView.DequeueReusableCell(PointsTwoButtonTableViewCell.Key, indexPath);
                    cell3.SelectionStyle = UITableViewCellSelectionStyle.None;

                    cell3.ButtonOne.TitleLabel.Text = "Points Transactions";
                    cell3.ButtonOne.TitleLabel.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Light);
                    cell3.ButtonOne.TitleLabel.TextColor = UIColor.Black;
                    cell3.ButtonOne.BackgroundColor = UIColor.FromRGB(235,235,235);

                    UIBezierPath maskPath = UIBezierPath.FromRoundedRect(cell3.ButtonOne.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
                    CAShapeLayer maskLayer = new CAShapeLayer();
                    maskLayer.Frame = cell3.ButtonOne.Bounds;
                    maskLayer.Path = maskPath.CGPath;
                    cell3.ButtonOne.Layer.Mask = maskLayer;


                    cell3.ButtonTwo.TitleLabel.Text = "Pending Points";
                    cell3.ButtonTwo.TitleLabel.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Light);
                    cell3.ButtonTwo.TitleLabel.TextColor = UIColor.Black;
                    cell3.ButtonTwo.BackgroundColor = UIColor.White;

                    UIBezierPath maskPath1 = UIBezierPath.FromRoundedRect(cell3.ButtonTwo.Bounds, UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(5, 5));
                    CAShapeLayer maskLayer1 = new CAShapeLayer();
                    maskLayer1.Frame = cell3.ButtonOne.Bounds;
                    maskLayer1.Path = maskPath1.CGPath;
                    cell3.ButtonTwo.Layer.Mask = maskLayer1;


                    //Cell background colour
                    cell3.BackgroundColor = UIColor.Clear;

                    return cell3;

                case 4:
                    var cell4 = (RewardsTableViewCell)tableView.DequeueReusableCell(RewardsTableViewCell.Key, indexPath);
                    cell4.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell4;

                case 5:
                    var cell5 = (RewardsTableViewCell)tableView.DequeueReusableCell(RewardsTableViewCell.Key, indexPath);
                    cell5.SelectionStyle = UITableViewCellSelectionStyle.None;
                    return cell5;

                case 6:
                    //var cell4 = (RewardsTableViewCell)tableView.DequeueReusableCell(RewardsTableViewCell.Key, indexPath);
                    //cell4.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //return cell4;

                    //var cell4 = (PollPopupTableViewCell)tableView.DequeueReusableCell(PollPopupTableViewCell.Key, indexPath);
                    //cell4.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //UIViewHelper.SetShadow(cell4.ViewMain, 10, 1, 5, 5, 5);
                    //cell4.ViewMain.BackgroundColor = UIColor.White;

                    //cell4.BackgroundColor = UIColor.White;
                    //return cell4;


                    var cell6 = (PointsTwoLabelRoundedCellTableViewCell)tableView.DequeueReusableCell(PointsTwoLabelRoundedCellTableViewCell.Key, indexPath);
                    cell6.SelectionStyle = UITableViewCellSelectionStyle.None;
                    //UIViewHelper.SetShadow(cell4.ViewMain, 10, 1, 5, 5, 5);
                    cell6.ViewMain.Layer.CornerRadius = 20;
                    cell6.ViewMain.BackgroundColor = UIColor.FromRGB(24,113,123);

                    cell6.BackgroundColor = UIColor.Clear;
                    return cell6;

                case 7:

                    var cell7 = (PollPopupTableViewCell)tableView.DequeueReusableCell(PollPopupTableViewCell.Key, indexPath);
                    cell7.SelectionStyle = UITableViewCellSelectionStyle.None;
                    UIViewHelper.SetShadow(cell7.ViewMain, 10, 1, 5, 5, 5);
                    cell7.ViewMain.BackgroundColor = UIColor.White;

                    cell7.BackgroundColor = UIColor.White;
                    return cell7;

                case 8:

                    var cell8 = (PointsTwoLabelTableViewCell)tableView.DequeueReusableCell(PointsTwoLabelTableViewCell.Key, indexPath);
                    cell8.SelectionStyle = UITableViewCellSelectionStyle.None;
                    cell8.LabelYourLedger.Text = "Your Earning History";
                    cell8.LabelYourLedger.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                    cell8.LabelYourLedger.TextColor = UIColor.Black;

                    cell8.LabelPoints.Text = "";
                    cell8.LabelPoints.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                    cell8.LabelPoints.TextColor = UIColor.Black;

                    //Cell background colour
                    cell8.BackgroundColor = UIColor.Clear;

                    return cell8;

                case 9:

                    var cell9 = (PointsEarningHistoryTableViewCell)tableView.DequeueReusableCell(PointsEarningHistoryTableViewCell.Key, indexPath);
                    cell9.SelectionStyle = UITableViewCellSelectionStyle.None;


                    cell9.LabelTitle.Text = "You earned the social sharer Badge from Harriett Casey accepting your invite";
                    cell9.LabelTitle.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Regular);
                    cell9.LabelTitle.TextColor = UIColor.FromRGB(154,154,154);

                    cell9.LabelDescription.Text = "2 hours ago";
                    cell9.LabelDescription.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Light);
                    cell9.LabelDescription.TextColor = UIColor.Black;

                    //cell9.ViewTopLine.Hidden = true;
                    cell9.ViewBackgroundLine.Hidden = false;

                    cell9.ViewMain.BackgroundColor = UIColor.Clear;
                    cell9.BackgroundColor = UIColor.Clear;
                    return cell9;

                case 10:

                    var cell10 = (PointsEarningHistoryTableViewCell)tableView.DequeueReusableCell(PointsEarningHistoryTableViewCell.Key, indexPath);
                    cell10.SelectionStyle = UITableViewCellSelectionStyle.None;


                    cell10.LabelTitle.Text = "You sent an invite to Calvin Hall";
                    cell10.LabelTitle.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Regular);
                    cell10.LabelTitle.TextColor = UIColor.FromRGB(154, 154, 154);

                    cell10.LabelDescription.Text = "1 day ago";
                    cell10.LabelDescription.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Light);
                    cell10.LabelDescription.TextColor = UIColor.Black;

                    //cell10.ViewTopLine.Hidden = false;
                    cell10.ViewBackgroundLine.Hidden = false;

                    cell10.ViewMain.BackgroundColor = UIColor.Clear;
                    cell10.BackgroundColor = UIColor.Clear;
                    return cell10;

                case 11:

                    var cell11 = (PointsEarningHistoryTableViewCell)tableView.DequeueReusableCell(PointsEarningHistoryTableViewCell.Key, indexPath);
                    cell11.SelectionStyle = UITableViewCellSelectionStyle.None;


                    cell11.LabelTitle.Text = "Harriett Casey accepted your invitation";
                    cell11.LabelTitle.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Regular);
                    cell11.LabelTitle.TextColor = UIColor.FromRGB(154, 154, 154);

                    cell11.LabelDescription.Text = "3 day ago";
                    cell11.LabelDescription.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Light);
                    cell11.LabelDescription.TextColor = UIColor.Black;

                    //cell11.ViewTopLine.Hidden = false;
                    cell11.ViewBackgroundLine.Hidden = false;

                    cell11.ViewMain.BackgroundColor = UIColor.Clear;
                    cell11.BackgroundColor = UIColor.Clear;
                    return cell11;


                default:
                    var cellDefault = new UITableViewCell();
                    return cellDefault;
            }   
        }

            
        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 12;
        }

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
            if (indexPath.Row == 7)
            {
                return 250;
            }
            return UITableView.AutomaticDimension;
		}
	}
}

