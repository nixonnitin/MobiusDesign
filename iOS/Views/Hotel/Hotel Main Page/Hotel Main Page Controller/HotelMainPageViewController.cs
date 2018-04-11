using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public partial class HotelMainPageViewController : UIViewController
    {
        List<string> labels;
        List<string> labelData;
        List<string> labelFacility;
        List<string> collectionViewLabels;
        List<string> collectionViewImages;

        public HotelMainPageViewController() : base("HotelMainPageViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.


            labels = new List<string> { "Double Suite", "Queen Double Deluxe", "Grand King Suite", "Family Triple Suite" };
            labelData = new List<string> { "$65.50 per night", "$73.75 per night", "$120.25 per night", "$145.50 per night" };
            labelFacility = new List<string> { "Our Facilities", "Adipiscing elit, sed do eiusmod tempor incididunt","Adipiscing elit, sed do eiusmod tempor incididunt" };

            collectionViewLabels = new List<string> { "On-Site Parking", "24-Hours Front Desk", "Complimentary Wireless Internet", "Denny's Restaurant" };
            collectionViewImages = new List<string> { "parking-1", "food-1", "gym", "homeWiFi" };

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
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelListCell", NSBundle.MainBundle), "HotelListCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelLocationMapCell", NSBundle.MainBundle), "HotelLocationMapCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelLabelCell", NSBundle.MainBundle), "HotelLabelCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelMoreCell", NSBundle.MainBundle), "HotelMoreCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelDateGuestCell", NSBundle.MainBundle), "HotelDateGuestCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HomeCollectionContainerCell", NSBundle.MainBundle), "HomeCollectionContainerCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HomeButtonCell", NSBundle.MainBundle), "HomeButtonCell");
            TableViewMainPage.RegisterNibForCellReuse(UINib.FromName("HotelLowestPriceWithDataCell", NSBundle.MainBundle), "HotelLowestPriceWithDataCell");



            TableViewMainPage.Source = new TableViewMainPageSource(TableViewMainPage, labels, labelData,labelFacility,collectionViewLabels,collectionViewImages);
        }
    }

    public class TableViewMainPageSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelData;
        List<string> labelFacility;
        List<string> collectionViewLabels;
        List<string> collectionViewImages;

        public TableViewMainPageSource(UITableView table, List<string> labels, List<string> labelData, List<string> labelFacility, List<string> collectionViewLabels, List<string> collectionViewImages)
        {
            this.table = table;
            this.labels = labels;
            this.labelData = labelData;
            this.labelFacility = labelFacility;
            this.collectionViewLabels = collectionViewLabels;
            this.collectionViewImages = collectionViewImages;
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

                //Display price
                cell.LabelDisplayPRice.Text = "Display Price:";
                cell.LabelDisplayPRice.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Medium);
                cell.LabelDisplayPRice.TextColor = UIColor.Black;

                //Money
                cell.ButtonMoney.SetTitle("Money", UIControlState.Normal);
                cell.ButtonMoney.TitleLabel.Font = UIFont.SystemFontOfSize(13, UIFontWeight.Light);
                cell.ButtonMoney.TitleLabel.TextColor = UIColor.White;
                cell.ButtonMoney.BackgroundColor = UIColor.FromRGB(28, 132, 143);
                cell.ButtonMoney.Layer.BorderColor = UIColor.FromRGB(28, 132, 143).CGColor;
                cell.ButtonMoney.Layer.BorderWidth = 1.0f;
                cell.ButtonMoney.Layer.MasksToBounds = true;
                cell.ButtonMoney.Layer.CornerRadius = 5;

                //Points
                cell.ButtonPoints.SetTitle("Points", UIControlState.Normal);
                cell.ButtonPoints.TitleLabel.Font = UIFont.SystemFontOfSize(13, UIFontWeight.Light);
                cell.ButtonPoints.TitleLabel.TextColor = UIColor.FromRGB(28, 132, 143);
                cell.ButtonPoints.BackgroundColor = UIColor.White;
                cell.ButtonPoints.Layer.BorderColor = UIColor.FromRGB(28, 132, 143).CGColor;
                cell.ButtonPoints.Layer.BorderWidth = 1.0f;
                cell.ButtonPoints.Layer.MasksToBounds = true;
                cell.ButtonPoints.Layer.CornerRadius = 5;

                //Background color of cell
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);

                return cell;
            }
            else if (indexPath.Row < labels.Count + 4)
            {
                var cell = (HotelListCell)tableView.DequeueReusableCell(HotelListCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Room type
                cell.LabelRoomType.Text = labels[indexPath.Row-4];
                cell.LabelRoomType.Font = UIFont.SystemFontOfSize(19, UIFontWeight.Medium);
                cell.LabelRoomType.TextColor = UIColor.Black;

                //Price per night
                cell.LabelPricePerNight.Text = labelData[indexPath.Row-4];
                cell.LabelPricePerNight.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Medium);
                cell.LabelPricePerNight.TextColor = UIColor.FromRGB(28, 132, 143);

                cell.ImageViewNext.Image = UIImage.FromBundle("next-arrrow-1");
                cell.ImageViewRoom.Image = UIImage.FromBundle("");

                //Rounded corners
                cell.ViewMain.Layer.MasksToBounds = true;
                cell.ViewMain.Layer.CornerRadius = 5;

                //Cell background 
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);


                UIViewHelper.SetShadow(cell, 0);

                return cell;
            }
            else if (indexPath.Row == labels.Count + 4)
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
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);

                UIViewHelper.SetShadow(cell, 0);

                return cell;
            }
            else if (indexPath.Row == labels.Count + 5) 
            {
                var cell = (HotelLabelCell)tableView.DequeueReusableCell(HotelLabelCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Text
                cell.LabelText.Text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
                cell.LabelText.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Light);
                cell.LabelText.TextColor = UIColor.Black;

                //Cell background 
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);

                return cell;

            }
            else if (indexPath.Row == labels.Count + 6)
            {
                var cell = (HotelLabelCell)tableView.DequeueReusableCell(HotelLabelCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Text
                cell.LabelText.Text = "Find Out More:";
                cell.LabelText.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Medium);
                cell.LabelText.TextColor = UIColor.Black;

                //Cell background 
                cell.BackgroundColor = UIColor.FromRGB(225, 225, 225);

                return cell;

            }
            else if (indexPath.Row <= labels.Count + 6 + labelFacility.Count)
            {
                var cell = (HotelMoreCell)tableView.DequeueReusableCell(HotelMoreCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Text
                cell.LabelFacility.Text = labelFacility[indexPath.Row-4-labels.Count-3];
                cell.LabelFacility.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Light);
                cell.LabelFacility.TextColor = UIColor.Black;

                //Rounded reviewer image
                cell.ImageViewFacility.Layer.CornerRadius = cell.ImageViewFacility.Frame.Size.Width / 2;

                //Cell background 
                cell.BackgroundColor = UIColor.White;

                return cell;

            }
            else if (indexPath.Row == labels.Count + 6 + labelFacility.Count + 1)
            {
                var cell = (HotelDateGuestCell)tableView.DequeueReusableCell(HotelDateGuestCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;


                return cell;
            }
            else
            {
                //var cell = (HomeCollectionContainerCell)tableView.DequeueReusableCell(HomeCollectionContainerCell.Key, indexPath);
                //cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.CollectionViewHomeCell.RegisterNibForCell(UINib.FromName("HotelAmenitiesCollectionCell", NSBundle.MainBundle), "HotelAmenitiesCollectionCell");
                //var layout = new UICollectionViewFlowLayout();
                //layout.ScrollDirection = UICollectionViewScrollDirection.Horizontal;
                //cell.CollectionViewHomeCell.CollectionViewLayout = layout;
                //cell.ConstraintCollectionViewHeight.Constant = tableView.Frame.Height * (nfloat)0.20;

                //cell.CollectionViewHomeCell.Source = new HotelCollectionViewSource(cell.CollectionViewHomeCell,collectionViewLabels, collectionViewImages);
                //cell.CollectionViewHomeCell.Delegate = new HotelCollectionViewDelegate(cell.CollectionViewHomeCell);
                //return cell;







                //var cell = (HotelLabelCell)tableView.DequeueReusableCell(HotelLabelCell.Key, indexPath);
                //cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                ////Text
                //cell.LabelText.Text = "This hotel was last booked 10 minutes ago";
                //cell.LabelText.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Light);
                //cell.LabelText.TextColor = UIColor.Black;
                //cell.LabelText.TextAlignment = UITextAlignment.Center;

                ////Cell background 
                //cell.BackgroundColor = UIColor.Orange;

                //return cell;





                //var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                //cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                //cell.BookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                ////cell.BookYourStay.Layer.BorderWidth = 1;
                ////cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                ////                self.yourView.layer.borderWidth = 1
                ////self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                //cell.BookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                //cell.BookYourStay.SetTitle("View Rooms", UIControlState.Normal);
                //cell.BookYourStay.TitleLabel.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Bold);
                //return cell;


                var cell = (HotelLowestPriceWithDataCell)tableView.DequeueReusableCell(HotelLowestPriceWithDataCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Lowest PRice
                cell.LabelLowestPRice.Text = "Lowest Price:";
                cell.LabelLowestPRice.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Medium);
                cell.LabelLowestPRice.TextColor = UIColor.White;

                //PRice
                cell.LabelPRice.Text = "$65.50";
                cell.LabelPRice.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Medium);
                cell.LabelPRice.TextColor = UIColor.White;

                //Date
                cell.LabelDate.Text = "29 Aug - 31 Aug 2018";
                cell.LabelDate.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Light);
                cell.LabelDate.TextColor = UIColor.White;

                //View Date
                cell.LabelViewDate.Text = "29 Aug - 31 Aug 2018";
                cell.LabelViewDate.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.LabelViewDate.TextColor = UIColor.White;

                //Image View Cal
                cell.ImageViewCal.Image = UIImage.FromBundle("calWhite");

                //Image View Cal
                cell.ImageViewDropDown.Image = UIImage.FromBundle("");

                cell.ViewDate.BackgroundColor = UIColor.FromRGB(24, 113, 123);

                cell.BackgroundColor = UIColor.FromRGB(30,132,154);

                return cell;



            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            // Initail 4 for 4 table cells 
            // Labels contains hotel room type so count of those
            // 3 is for label cells 
            // LabelFacility for Find more options
            // Last 1 is for the last date cell
            return 4 + labels.Count + 3 + labelFacility.Count + 1 + 1;
        }


    }
}

