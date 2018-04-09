using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace Mobius.iOS.Views
{
    public partial class HotelReview : UIViewController
    {
        List<string> labels;
        List<string> labelData;

        public HotelReview() : base("HotelReview", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Sara Ramsey", "Lucy Hampton","Ricardo Gregory","Elva Sims" };
            labelData = new List<string> { "Amazing hotel with great views.! Would highly recommned", "Lorem ipsum dolor sit amet, consectetur adipiscing elit,sed do.","Amazing hotel with great views.! Would highly recommned","Amazing hotel with great views.! Would highly recommned" };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewHotelReview.RowHeight = UITableView.AutomaticDimension;
            TableViewHotelReview.EstimatedRowHeight = 111;
            TableViewHotelReview.RegisterNibForCellReuse(UINib.FromName("HotelReviewCell", NSBundle.MainBundle), "HotelReviewCell");
            TableViewHotelReview.Source = new TableViewHotelReviewSource(TableViewHotelReview, labels, labelData);
        }
    }


    public class TableViewHotelReviewSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelData;

        public TableViewHotelReviewSource(UITableView table, List<string> labels, List<string> labelData)
        {
            this.table = table;
            this.labels = labels;
            this.labelData = labelData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (HotelReviewCell)tableView.DequeueReusableCell(HotelReviewCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            cell.LabelName.Text = labels[indexPath.Row];
            cell.LabelName.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Regular);
            cell.LabelName.TextColor = UIColor.Black;

            cell.LabelReview.Text = labelData[indexPath.Row];
            cell.LabelReview.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
            cell.LabelReview.TextColor = UIColor.FromRGB(140, 140, 140);

            cell.ImageViewProfile.Layer.CornerRadius = cell.ImageViewProfile.Frame.Size.Width / 2;

            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return labels.Count;
        }


    }
}

