using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;
using CoreAnimation;
using System.Drawing;

namespace Mobius.iOS.Views
{
    public partial class ConfirmationViewController : UIViewController
    {

        List<string> labels;
        List<string> labelsData;
        public ConfirmationViewController() : base("ConfirmationViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Breakfast", "Dinner & Drinks Special", "Hotel Guest Protection Cover" };
            labelsData = new List<string> { "25 points or $25", "250 points or $250", "30 points or $30" };
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewConfirmation.RowHeight = UITableView.AutomaticDimension;
            TableViewConfirmation.EstimatedRowHeight = 111;
            TableViewConfirmation.BackgroundColor = UIColor.FromRGB(246, 246, 246);
            TableViewConfirmation.RegisterNibForCellReuse(UINib.FromName("ConfirmationHotelDetailsTableViewCell", NSBundle.MainBundle), "ConfirmationHotelDetailsTableViewCell");
            TableViewConfirmation.RegisterNibForCellReuse(UINib.FromName("PointsTwoLabelTableViewCell", NSBundle.MainBundle), "PointsTwoLabelTableViewCell");
            TableViewConfirmation.RegisterNibForCellReuse(UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle), "HomeEnhancementsCell");
            TableViewConfirmation.RegisterNibForCellReuse(UINib.FromName("HotelLocationMapCell", NSBundle.MainBundle), "HotelLocationMapCell");



            TableViewConfirmation.Source = new TableViewConfirmationSource(TableViewConfirmation, labels, labelsData);

        }
    }

    public class TableViewConfirmationSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelsData;

        public TableViewConfirmationSource(UITableView table, List<string> labels, List<string> labelsData)
        {
            this.table = table;
            this.labels = labels;
            this.labelsData = labelsData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (PointsTwoLabelTableViewCell)tableView.DequeueReusableCell(PointsTwoLabelTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelYourLedger.Text = "Confirmation number:";
                cell.LabelYourLedger.Font = UIFont.SystemFontOfSize(19, UIFontWeight.Medium);
                cell.LabelYourLedger.TextColor = UIColor.Black;

                cell.LabelPoints.Text = "NYC-JK-0192";
                cell.LabelPoints.Font = UIFont.SystemFontOfSize(22, UIFontWeight.Medium);
                cell.LabelPoints.TextColor = MobiusHelper.GetColorTextGreen();
                //cell.ConstraintLabelPoints.Constant = 140;
                //Cell background colour
                cell.BackgroundColor = UIColor.Clear;

                return cell;
            }
            else if (indexPath.Row == 1)
            {
                var cell1 = (ConfirmationHotelDetailsTableViewCell)tableView.DequeueReusableCell(ConfirmationHotelDetailsTableViewCell.Key, indexPath);
                cell1.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Rounded corner for top view
                UIBezierPath maskPath = UIBezierPath.FromRoundedRect(cell1.LblLimitedTimeOffer.Bounds, UIRectCorner.BottomLeft | UIRectCorner.BottomRight, new CoreGraphics.CGSize(10, 10));
                CAShapeLayer maskLayer = new CAShapeLayer();
                maskLayer.Frame = cell1.LblLimitedTimeOffer.Bounds;
                maskLayer.Path = maskPath.CGPath;
                cell1.LblLimitedTimeOffer.Layer.Mask = maskLayer;

                //Cell main view border and corner radius
                cell1.ViewMain.Layer.BorderColor = MobiusHelper.GetColorBorderGrey().CGColor;
                cell1.ViewMain.Layer.BorderWidth = 2;
                cell1.ViewMain.Layer.CornerRadius = 10;
                cell1.ViewMain.BackgroundColor = UIColor.White;
                cell1.ViewMain.Layer.MasksToBounds = true;

                //Cell background colour
                cell1.BackgroundColor = UIColor.Clear;
                return cell1;
            }
            else if (indexPath.Row == 2)
            {
                var cell2 = (PointsTwoLabelTableViewCell)tableView.DequeueReusableCell(PointsTwoLabelTableViewCell.Key, indexPath);
                cell2.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell2.LabelYourLedger.Text = "Recommended Enhancements:";
                cell2.LabelYourLedger.Font = UIFont.SystemFontOfSize(19, UIFontWeight.Medium);
                cell2.LabelYourLedger.TextColor = UIColor.Black;

                cell2.LabelPoints.Text = "";
                cell2.LabelPoints.Font = UIFont.SystemFontOfSize(22, UIFontWeight.Medium);
                cell2.LabelPoints.TextColor = UIColor.FromRGB(65, 117, 194);
                //cell2.ConstraintLabelPoints.Constant = 0;

                //Cell background colour
                cell2.BackgroundColor = UIColor.Clear;

                return cell2;
            }
            else if (indexPath.Row < labels.Count + 3 && indexPath.Row >= 3)
            {
                var cell3 = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
                cell3.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell3.ConstraintSelectedViewWidth.Constant = 0;

                //cell3.LabelTitle.Text = labels[indexPath.Row - 3];
                //cell3.LabelTitle.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Medium);
                //cell3.LabelTitle.TextColor = UIColor.Black;

                cell3.LabelPointsDetail.Text = labelsData[indexPath.Row - 3];
                cell3.LabelPointsDetail.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Medium);
                cell3.LabelPointsDetail.TextColor = MobiusHelper.GetColorTextGreen();

                //cell3.ViewMain.Layer.CornerRadius = 10;
                //cell3.ViewMain.Layer.MasksToBounds = true;
                cell3.BackgroundColor = UIColor.Clear;


                cell3.LayoutSubviews();
                return cell3;
            }
            else
            {
                var cell = (HotelLocationMapCell)tableView.DequeueReusableCell(HotelLocationMapCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Location
                cell.LabelLocation.Text = "Location";
                cell.LabelLocation.Font = UIFont.SystemFontOfSize(19, UIFontWeight.Medium);
                cell.LabelLocation.TextColor = UIColor.FromRGB(28, 132, 143);

                //Image location
                cell.ImageViewLocation.Image = UIImage.FromBundle("location");

                //Address
                cell.LabelAddress.Text = "632 Streich Well, New York, NY 10163-4668, US";
                cell.LabelAddress.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Light);
                cell.LabelAddress.TextColor = UIColor.Black;

                //Rounded corners
                cell.ViewMain.Layer.MasksToBounds = true;
                cell.ViewMain.Layer.CornerRadius = 5;

                //Cell background 
                cell.BackgroundColor = UIColor.Clear;
                cell.ViewMain.Layer.CornerRadius = 10;

                return cell;
            }
        }

        public void ResizeHeigthWithText(UILabel label, float maxHeight = 960f)
        {
            nfloat width = label.Frame.Width;
            SizeF size = (System.Drawing.SizeF)((NSString)label.Text).StringSize(label.Font, constrainedToSize: new SizeF((float)width, maxHeight), lineBreakMode: UILineBreakMode.WordWrap);
            var labelFrame = label.Frame;
            labelFrame.Size = new SizeF((float)width, size.Height);
            label.Frame = labelFrame;
        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 4 + labels.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                return 70;
            }
            else if (indexPath.Row == 1)
            {
                return 340;
            }
            else if (indexPath.Row < labels.Count + 3 && indexPath.Row >= 3)
            {
                return 105;
            }

            return UITableView.AutomaticDimension;
        }
    }
}

