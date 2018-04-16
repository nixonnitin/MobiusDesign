using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public partial class PollListViewController : UIViewController
    {
        List<string> labels;

        public PollListViewController() : base("PollListViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "What is your main reason for booking with us?", "Adipiscing elit, sed do eiusmod tempor incidicunt", "Adipiscing elit, sed do eiusmod tempor incidicunt", "Adipiscing elit, sed do eiusmod tempor incidicunt" };
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewPollList.RowHeight = UITableView.AutomaticDimension;
            TableViewPollList.EstimatedRowHeight = 100;
            TableViewPollList.BackgroundColor = UIColor.FromRGB(225, 225, 225);
            TableViewPollList.RegisterNibForCellReuse(UINib.FromName("PollTopCellTableViewCell", NSBundle.MainBundle), "PollTopCellTableViewCell");
            TableViewPollList.RegisterNibForCellReuse(UINib.FromName("HotelMoreCell", NSBundle.MainBundle), "HotelMoreCell");

            TableViewPollList.Source = new TableViewPollListSource(TableViewPollList, labels);

        }
    }

    public class TableViewPollListSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;

        public TableViewPollListSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (PollTopCellTableViewCell)tableView.DequeueReusableCell(PollTopCellTableViewCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Text poll title
                cell.LabelPollTitile.Text = "This is the poll title";
                cell.LabelPollTitile.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                cell.LabelPollTitile.TextColor = UIColor.Black;

                //Text complete poll
                cell.LabelCompletePoll.Text = "Complete polls to earn 5 Points";
                cell.LabelCompletePoll.Font = UIFont.SystemFontOfSize(13, UIFontWeight.Medium);
                cell.LabelCompletePoll.TextColor = UIColor.FromRGB(154,154,154);

                //Text take poll
                cell.LabelCompletePoll.Text = "Take Poll";
                cell.LabelCompletePoll.Font = UIFont.SystemFontOfSize(12, UIFontWeight.Regular);
                cell.LabelCompletePoll.TextColor = UIColor.FromRGB(154, 154, 154);


                cell.BackgroundColor = UIColor.Clear;
                return cell;
            }
            else 
            {
                var cell1 = (HotelMoreCell)tableView.DequeueReusableCell(HotelMoreCell.Key, indexPath);
                cell1.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Text
                cell1.LabelFacility.Text = labels[indexPath.Row - 1];
                cell1.LabelFacility.Font = UIFont.SystemFontOfSize(17, UIFontWeight.Light);
                cell1.LabelFacility.TextColor = UIColor.Black;

                //Rounded reviewer image
                cell1.ImageViewFacility.Layer.CornerRadius = cell1.ImageViewFacility.Frame.Size.Width / 2;

                if (indexPath.Row % 2 == 0)
                {
                    cell1.ViewLabelAndImage.Hidden = false;
                    cell1.ViewLabelAndImage.Layer.CornerRadius = cell1.ViewLabelAndImage.Frame.Size.Width / 2;
                }
                else
                {
                    cell1.ViewLabelAndImage.Hidden = true;
                }


                //Cell background 
                cell1.BackgroundColor = UIColor.White;



                return cell1;
            }
        }


        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return 1 + labels.Count;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            // In here you could customize how you want to get the height for row. Then   
            // just return it. 

            if (indexPath.Row == 0)
            {
                return 100;
            }
            else
            {
                return UITableView.AutomaticDimension;
            }
        }
    }
}

