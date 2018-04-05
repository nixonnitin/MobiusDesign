using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class BookSearch : UIViewController
    {
        List<string> labels;
        List<string> labels1;
        List<string> images;

        public BookSearch() : base("BookSearch", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            initData();
            initUI();
        }

        private void initData()
        {
            labels = new List<string> { "Hotel Location", "Dates", "Rooms" };
            labels1 = new List<string> { "Choose a Location", "Select Your Dates", "Select Guests & Rooms" };
            images = new List<string> { "location", "cal", "homePerson" };
        }

        private void initUI()
        {
            //var tableViewLovalty = new UITableView(View.Bounds, UITableViewStyle.Grouped);
            //tableViewLovalty.Source = new LovaltyDataSource(tableViewLovalty, labels, images);
            //tableViewLovalty.RowHeight = UITableView.AutomaticDimension;
            //tableViewLovalty.EstimatedRowHeight = 64;

            //View.AddSubview(tableViewLovalty);
            tblMenu.RowHeight = UITableView.AutomaticDimension;
            tblMenu.EstimatedRowHeight = 64;
            tblMenu.RegisterNibForCellReuse(UINib.FromName("BookSearchCell1", NSBundle.MainBundle), "BookSearchCell1");
            tblMenu.RegisterNibForCellReuse(UINib.FromName("BookSearchCell2", NSBundle.MainBundle), "BookSearchCell2");
            tblMenu.RegisterNibForCellReuse(UINib.FromName("BookSearchAvailabilityCell", NSBundle.MainBundle), "BookSearchAvailabilityCell");
            tblMenu.Source = new BookSearchSource(tblMenu, labels,labels1, images);


        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }


    public class BookSearchSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labels1;
        List<string> images;

        public BookSearchSource(UITableView table, List<string> labels, List<string> labels1, List<string> images)
        {
            this.table = table;
            this.labels = labels;
            this.labels1 = labels1;
            this.images = images;

            //table.RegisterNibForCellReuse(UINib.FromName("MenuExistingUserCell1", NSBundle.MainBundle), MenuExistingUserCell1.Key);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row < 3)
            {
                var cell = (BookSearchCell1)tableView.DequeueReusableCell(BookSearchCell1.Key, indexPath);
                //cell.imgIcon.Image = UIImage.FromFile(images[indexPath.Row]);
                cell.lbl1.Text = labels[indexPath.Row];
                cell.lbl2.Text = labels1[indexPath.Row];
                cell.ImageView1.Image = UIImage.FromBundle(images[indexPath.Row]);
                cell.ImageView2.Image = UIImage.FromBundle("homeNextArrow");
                return cell;
            }
            else if (indexPath.Row == 3)
            {
                var cell = (BookSearchCell2)tableView.DequeueReusableCell(BookSearchCell2.Key, indexPath);
                //cell.imgIcon.Image = UIImage.FromFile(images[indexPath.Row]);
                cell.LabelTop.Text = "Discount Code:";

                return cell;
            }
            else
            {
                var cell = (BookSearchAvailabilityCell)tableView.DequeueReusableCell(BookSearchAvailabilityCell.Key, indexPath);
                cell.ButtonName.SetTitle("Check Availablity", UIControlState.Normal);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return labels.Count + 2;
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

    }
}

