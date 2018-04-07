using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using CoreAnimation;
using Mobius.iOS.Helpers;

namespace Mobius.iOS.Views
{
    public partial class MainResultViewController : UIViewController
    {
        List<string> labels;
        List<string> labels1;
        List<string> images;

        public MainResultViewController() : base("MainResultViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            // Initialize data
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
            labels = new List<string> { "Hotel Location", "Dates", "Rooms" };
            labels1 = new List<string> { "Choose a Location", "Select Your Dates", "Select Guests & Rooms" };
            images = new List<string> { "location", "cal", "homePerson" };
        }

        private void initUI()
        {
            TableViewMainResult.RowHeight = UITableView.AutomaticDimension;
            TableViewMainResult.EstimatedRowHeight = 311;
            TableViewMainResult.RegisterNibForCellReuse(UINib.FromName("MainResultCell", NSBundle.MainBundle), "MainResultCell");
            TableViewMainResult.RegisterNibForCellReuse(UINib.FromName("MainResultHotelCountCell", NSBundle.MainBundle), "MainResultHotelCountCell");
            TableViewMainResult.RegisterNibForCellReuse(UINib.FromName("MainResultNoResultFoundCell", NSBundle.MainBundle), "MainResultNoResultFoundCell");
            TableViewMainResult.Source = new MainResultSource(TableViewMainResult, labels, labels1, images);
        }
    }

    public class MainResultSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labels1;
        List<string> images;

        public MainResultSource(UITableView table, List<string> labels, List<string> labels1, List<string> images)
        {
            this.table = table;
            this.labels = labels;
            this.labels1 = labels1;
            this.images = images;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (MainResultHotelCountCell)tableView.DequeueReusableCell(MainResultHotelCountCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                return cell;
            }
            else
            {
                var cell = (MainResultCell)tableView.DequeueReusableCell(MainResultCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Top info view rounded corner two sided
                UIBezierPath maskPath = UIBezierPath.FromRoundedRect(cell.ViewTopInfo.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft, new CoreGraphics.CGSize(10, 10));
                CAShapeLayer maskLayer = new CAShapeLayer();
                maskLayer.Frame = cell.ViewTopInfo.Bounds;
                maskLayer.Path = maskPath.CGPath;
                cell.ViewTopInfo.Layer.Mask = maskLayer;

                //Discounted view rounded corners
                UIBezierPath maskPath1 = UIBezierPath.FromRoundedRect(cell.LabelDiscount.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft | UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(10, 10));
                CAShapeLayer maskLayer1 = new CAShapeLayer();
                maskLayer1.Frame = cell.LabelDiscount.Bounds;
                maskLayer1.Path = maskPath1.CGPath;
                cell.LabelDiscount.Layer.Mask = maskLayer1;

                //Rounded corners for Cell
                UIBezierPath maskPath2 = UIBezierPath.FromRoundedRect(cell.ViewMain.Bounds, UIRectCorner.BottomRight | UIRectCorner.BottomLeft | UIRectCorner.TopLeft | UIRectCorner.TopRight, new CoreGraphics.CGSize(10, 10));
                CAShapeLayer maskLayer2 = new CAShapeLayer();
                maskLayer2.Frame = cell.ViewMain.Bounds;
                maskLayer2.Path = maskPath2.CGPath;
                cell.ViewMain.Layer.Mask = maskLayer2;

                //Show select date for price view and hide other labels
                /*
                cell.ViewSelectDateForPrice.Hidden = false;
                cell.LabelSelectDateForPrice.Text = "Select dates for price";
                cell.LabelActualCostPerNight.Hidden = true;
                cell.LabelDiscountCostPerNight.Hidden = true;
                cell.LabelPerNight.Hidden = true;
                */

                //Adding Shadow to cell
                cell.ViewMain.BackgroundColor = UIColor.White;
                UIViewHelper.SetShadow(cell.ViewMain, 10);


                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //Plus 1 for count of hotels cell
            return 3 + 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);

            if (indexPath.Row == 0)
            {

            }
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                return 60;
            }
            return 311;
        }

    }
}

