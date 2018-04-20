using System;
using UIKit;
using System.Collections.Generic;
using Foundation;
using CoreGraphics;
using Mobius.iOS.Helper;

namespace Mobius.iOS.Views
{
    public partial class PollQuestionViewController : UIViewController
    {
        List<string> labels;

        public PollQuestionViewController() : base("PollQuestionViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Good value for money", "The onsite facilities", "The hotel locations", "The customer service","Other" };
            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewPollQuestion.RowHeight = UITableView.AutomaticDimension;
            TableViewPollQuestion.EstimatedRowHeight = 100;
            TableViewPollQuestion.BackgroundColor = UIColor.FromRGB(225, 225, 225);
            TableViewPollQuestion.RegisterNibForCellReuse(UINib.FromName("LocationChooseCell", NSBundle.MainBundle), "LocationChooseCell");
            TableViewPollQuestion.RegisterNibForCellReuse(UINib.FromName("CheckoutTermsConditionsCell", NSBundle.MainBundle), "CheckoutTermsConditionsCell");
            TableViewPollQuestion.RegisterNibForCellReuse(UINib.FromName("HomeButtonCell", NSBundle.MainBundle), "HomeButtonCell");


            TableViewPollQuestion.Source = new TableViewPollQuestionSource(TableViewPollQuestion, labels);

        }
    }

    public class TableViewPollQuestionSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;

        public TableViewPollQuestionSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                var cell = (LocationChooseCell)tableView.DequeueReusableCell(LocationChooseCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelLocation.Text = "What is your main reason for booking with us ?";
                cell.LabelLocation.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                cell.LabelLocation.TextColor = UIColor.Black;

                //Cell background colour
                cell.BackgroundColor = UIColor.Clear;

                return cell;
            }
            else if (indexPath.Row == labels.Count )
            {
                var cell = (HomeButtonCell)tableView.DequeueReusableCell(HomeButtonCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.bookYourStay.BackgroundColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f);
                //cell.BookYourStay.Layer.BorderWidth = 1;
                //cell.BookYourStay.Layer.BorderColor = new UIColor(red: 0.20f, green: 0.55f, blue: 0.61f, alpha: 1.0f).CGColor;
                //                self.yourView.layer.borderWidth = 1
                //self.yourView.layer.borderColor = UIColor(red: 222 / 255, green: 225 / 255, blue: 227 / 255, alpha: 1).cgColor
                cell.bookYourStay.SetTitleColor(UIColor.White, UIControlState.Normal);
                cell.bookYourStay.SetTitle("Submit", UIControlState.Normal);
                cell.bookYourStay.TitleLabel.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Bold);
                cell.bookYourStay.TitleLabel.TextColor = UIColor.White;

                cell.bookYourStay.Layer.CornerRadius = 5;

                //Cell background colour
                cell.BackgroundColor = UIColor.Clear;

                return cell;
            }
            else
            {
                var cell = (CheckoutTermsConditionsCell)tableView.DequeueReusableCell(CheckoutTermsConditionsCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;

                //Agree label
                cell.labelAgree.Text = labels[indexPath.Row - 1];
                cell.labelAgree.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Medium);
                cell.labelAgree.TextColor = UIColor.Black;

                //Terms label
                cell.labelTerms.Text = "";

                //View
                cell.viewContainer.BackgroundColor = UIColor.Clear;

                //Cell background colour
                cell.BackgroundColor = UIColor.Clear;
                return cell;
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

