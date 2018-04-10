using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class HotelMainPageViewController : UIViewController
    {
        List<string> labels;
        List<string> labelData;

        public HotelMainPageViewController() : base("HotelMainPageViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            labels = new List<string> { "Sara Ramsey", "Lucy Hampton", "Ricardo Gregory", "Elva Sims" };
            labelData = new List<string> { "Amazing hotel with great views.! Would highly recommned", "Lorem ipsum dolor sit amet, consectetur adipiscing elit,sed do.", "Amazing hotel with great views.! Would highly recommned", "Amazing hotel with great views.! Would highly recommned" };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewMainPage.RowHeight = UITableView.AutomaticDimension;
            TableViewMainPage.EstimatedRowHeight = 111;

            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelQuickBookImageCell", NSBundle.MainBundle), "HotelQuickBookImageCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelNamePriceCell", NSBundle.MainBundle), "HotelNamePriceCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelRatingCell", NSBundle.MainBundle), "HotelRatingCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelDisplayPriceCell", NSBundle.MainBundle), "HotelDisplayPriceCell");
            //TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HomeEnhancementsCell", NSBundle.MainBundle), "HomeEnhancementsCell");

            TableViewMainPage.Source = new TableViewMainPageSource(TableViewMainPage, labels, labelData);
        }
    }

    public class TableViewMainPageSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelData;

        public TableViewMainPageSource(UITableView table, List<string> labels, List<string> labelData)
        {
            this.table = table;
            this.labels = labels;
            this.labelData = labelData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (HotelQuickBookImageCell)tableView.DequeueReusableCell(HotelQuickBookImageCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ButtonLeft.SetImage(UIImage.FromBundle("ArrowWhitePrevious"), UIControlState.Normal);
                cell.ButtonRight.SetImage(UIImage.FromBundle("ArrowWhiteNext"), UIControlState.Normal);

                return cell;

            }
            else if (indexPath.Row == 1)
            {
                var cell = (HotelNamePriceCell)tableView.DequeueReusableCell(HotelNamePriceCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Hotel name
                cell.LabelHotelName.Text = "Calgary City Centre";
                cell.LabelHotelName.Font = UIFont.SystemFontOfSize(19, UIFontWeight.Medium);
                cell.LabelHotelName.TextColor = UIColor.Black;

                //Hotel city
                cell.LabelHotelCity.Text = "Calgary, Alberta, CA ";
                cell.LabelHotelCity.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Light);
                cell.LabelHotelCity.TextColor = UIColor.Black;

                //Hotel price
                cell.LabelHotelPRice.Text = "$65.50";
                cell.LabelHotelPRice.Font = UIFont.SystemFontOfSize(22, UIFontWeight.Medium);
                cell.LabelHotelPRice.TextColor = UIColor.Black;

                cell.ImageViewOwl.Image = UIImage.FromBundle("owl");
                cell.ImageVIewRating1.Image = UIImage.FromBundle("ratingfull");
                cell.ImageVIewRating2.Image = UIImage.FromBundle("ratingfull");
                cell.ImageVIewRating3.Image = UIImage.FromBundle("ratingfull");
                cell.ImageVIewRating4.Image = UIImage.FromBundle("ratingfull");
                cell.ImageVIewRating5.Image = UIImage.FromBundle("ratinghalf");

                //Background color of cell
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);
                return cell;
            }
            else if (indexPath.Row == 2)
            {
                var cell = (HotelRatingCell)tableView.DequeueReusableCell(HotelRatingCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Rating
                cell.LabelRating.Text = "8.9";
                cell.LabelRating.Font = UIFont.SystemFontOfSize(22, UIFontWeight.Medium);
                cell.LabelRating.TextColor = UIColor.Black;

                //Number of reviews
                cell.LabelNumberOfReviews.Text = "(Based on 2,314 Reviews)";
                cell.LabelNumberOfReviews.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Light);
                cell.LabelNumberOfReviews.TextColor = UIColor.FromRGB(140, 140, 140);

                //Rounded reviewer image
                cell.ImageViewReviewer1.Layer.CornerRadius = cell.ImageViewReviewer1.Frame.Size.Width / 2;
                cell.ImageViewReviewer2.Layer.CornerRadius = cell.ImageViewReviewer2.Frame.Size.Width / 2;
                cell.ImageViewReviewer3.Layer.CornerRadius = cell.ImageViewReviewer3.Frame.Size.Width / 2;

                cell.ImageViewNext.Image = UIImage.FromBundle("next-arrrow-1");

                //Background color of cell
                cell.BackgroundColor = UIColor.White;

                return cell;
            }
            else if (indexPath.Row == 3)
            {
                var cell = (HotelDisplayPriceCell)tableView.DequeueReusableCell(HotelDisplayPriceCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                cell.LabelDisplayPRice.Text = "Display Price:";

                return cell;
            }
            //else if (indexPath.Row < labels.Count + 4)
            //{
            //    var cell = (HomeEnhancementsCell)tableView.DequeueReusableCell(HomeEnhancementsCell.Key, indexPath);
            //    cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //    cell.ConstraintSelectedViewWidth.Constant = 0;
            //    cell.LabelPointsDetail.Hidden = false;
            //    return cell;
            //}
            else 
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
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 4;
        }


    }
}

