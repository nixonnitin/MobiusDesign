using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using CoreAnimation;

namespace Mobius.iOS.Views
{
    public partial class HotelQuickBookViewController : UIViewController
    {
        List<string> labels;
        List<string> labelData;

        public HotelQuickBookViewController() : base("HotelQuickBookViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "BOOK CHEAPEST", "BOOK CHEAPEST" };
            labelData = new List<string> { "Non-Cancellable Room", "Cancellable Room" };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewHotelQuickBook.RowHeight = UITableView.AutomaticDimension;
            TableViewHotelQuickBook.EstimatedRowHeight = 150;
            TableViewHotelQuickBook.RegisterNibForCellReuse(UINib.FromName("HotelQuickBookTopCell", NSBundle.MainBundle), "HotelQuickBookTopCell");
            TableViewHotelQuickBook.RegisterNibForCellReuse(UINib.FromName("HotelQuickBookImageCell", NSBundle.MainBundle), "HotelQuickBookImageCell");
            TableViewHotelQuickBook.RegisterNibForCellReuse(UINib.FromName("PriceAndBookCheapCell", NSBundle.MainBundle), "PriceAndBookCheapCell");
            TableViewHotelQuickBook.RegisterNibForCellReuse(UINib.FromName("BookSearchAvailabilityCell", NSBundle.MainBundle), "BookSearchAvailabilityCell");
            TableViewHotelQuickBook.Source = new TableViewHotelQuickBookSource(TableViewHotelQuickBook, labels, labelData);
        }
    }

    public class TableViewHotelQuickBookSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelData;

        public TableViewHotelQuickBookSource(UITableView table, List<string> labels, List<string> labelData)
        {
            this.table = table;
            this.labels = labels;
            this.labelData = labelData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (HotelQuickBookTopCell)tableView.DequeueReusableCell(HotelQuickBookTopCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelQuickCheckout.Text = "Quick Checkout";
                cell.LabelQuickCheckout.Font = UIFont.SystemFontOfSize(22, UIFontWeight.Medium);
                cell.LabelQuickCheckout.TextColor = UIColor.Black;

                cell.LabelBookOnlineGetBestPrice.Text = "Book Our Best Rate, Best Online Price Guarentee!";
                cell.LabelBookOnlineGetBestPrice.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Medium);
                cell.LabelBookOnlineGetBestPrice.TextColor = UIColor.FromRGB(52, 141, 155);


                return cell;
            }
            else if (indexPath.Row == 1)
            {
                var cell = (HotelQuickBookImageCell)tableView.DequeueReusableCell(HotelQuickBookImageCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.Layer.CornerRadius = 10;

                UIBezierPath maskPath = UIBezierPath.FromRoundedRect(cell.Bounds, UIRectCorner.BottomRight | UIRectCorner.TopRight | UIRectCorner.BottomLeft | UIRectCorner.TopLeft, new CoreGraphics.CGSize(5, 5));
                CAShapeLayer maskLayer = new CAShapeLayer();
                maskLayer.Frame = cell.Bounds;
                maskLayer.Path = maskPath.CGPath;
                cell.Layer.Mask = maskLayer;

                return cell;
            }
            else if (indexPath.Row < labels.Count + 2)
            {
                var cell = (PriceAndBookCheapCell)tableView.DequeueReusableCell(PriceAndBookCheapCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelPrice.Text = "$65";
                cell.LabelPrice.Font = UIFont.SystemFontOfSize(30, UIFontWeight.Bold);
                cell.LabelPrice.TextColor = UIColor.White;
                cell.LabelPrice.BackgroundColor = UIColor.Black;

                cell.LabelBookCheapest.Text = labels[indexPath.Row - 2];
                cell.LabelBookCheapest.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Medium);
                cell.LabelBookCheapest.TextColor = UIColor.White;

                cell.LabelCancellableOrNoRooms.Text = labelData[indexPath.Row - 2];
                cell.LabelCancellableOrNoRooms.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Light);
                cell.LabelCancellableOrNoRooms.TextColor = UIColor.White;

                cell.ViewMain.Layer.CornerRadius = 10;


                return cell;
            }
            else
            {
                var cell = (BookSearchAvailabilityCell)tableView.DequeueReusableCell(BookSearchAvailabilityCell.Key, indexPath);
                cell.ButtonName.SetTitle("Show All Rooms & Rates", UIControlState.Normal);
                cell.ButtonName.Layer.BorderColor = UIColor.FromRGB(52, 141, 155).CGColor;
                cell.ButtonName.Layer.BorderWidth = 1.0f;
                cell.ButtonName.Layer.MasksToBounds = true;
                cell.ButtonName.Layer.CornerRadius = 5;
                cell.ButtonName.BackgroundColor = UIColor.White;
                cell.ButtonName.TitleLabel.TextColor = UIColor.FromRGB(52, 141, 155);

                cell.SelectionStyle = UITableViewCellSelectionStyle.None;


                return cell;
            }

        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return labels.Count + 3;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                return 100;
            }
            else if (indexPath.Row == 1)
            {
                return 200;
            }
            else if (indexPath.Row < labels.Count + 2)
            {
                return 102;
            }
            return 60;
        }
    }
}

