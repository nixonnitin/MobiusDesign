using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using Mobius.iOS.Helper;
using CoreGraphics;

namespace Mobius.iOS.Views
{
    public partial class SearchFilterViewController : UIViewController
    {
        List<string> labels;
        List<string> sections;
        List<string> labelFeatures;

        public SearchFilterViewController() : base("SearchFilterViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //Initalize data
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
            labels = new List<string> { "Money", "Select a Rate Type","Select a Hotel Chain" };
            labelFeatures = new List<string> { "Airport Hotels", "Pet Friendly Hotels", "City Hotels" };
            sections = new List<string> { "Display Cost:", "Price:","Rate Type:", "Hotel Chain:","Features:","Amenities" };
        }

        private void initUI()
        {
            TableViewFilter.RowHeight = UITableView.AutomaticDimension;
            TableViewFilter.EstimatedRowHeight = 60;
            TableViewFilter.RegisterNibForCellReuse(UINib.FromName("SearchFilterDropDownCell", NSBundle.MainBundle), "SearchFilterDropDownCell");
            TableViewFilter.RegisterNibForCellReuse(UINib.FromName("SearchFilterPriceRangeCell", NSBundle.MainBundle), "SearchFilterPriceRangeCell");
            TableViewFilter.RegisterNibForCellReuse(UINib.FromName("SearchFilterSwitchCell", NSBundle.MainBundle), "SearchFilterSwitchCell");
            TableViewFilter.RegisterNibForCellReuse(UINib.FromName("SearchFilterResetApplyCell", NSBundle.MainBundle), "SearchFilterResetApplyCell");


            TableViewFilter.Source = new SearchFilterSource(TableViewFilter, labels,labelFeatures, sections);
        }
    }

    public class SearchFilterSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelFeatures;
        List<string> sections;

        public SearchFilterSource(UITableView table, List<string> labels, List<string> labelFeatures, List<string> sections)
        {
            this.table = table;
            this.labels = labels;
            this.labelFeatures = labelFeatures;
            this.sections = sections;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            if (indexPath.Section == 0)
            {
                var cell = (SearchFilterDropDownCell)tableView.DequeueReusableCell(SearchFilterDropDownCell.Key, indexPath);
                cell.LabelData.Text = labels[(int)indexPath.Section];
                cell.LabelData.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.LabelData.TextColor = UIColor.LightGray;

                cell.ImageViewDropDown.Image = UIImage.FromBundle("next-arrrow-1");

                cell.ViewMain.Layer.BorderColor = UIColor.FromRGB(224, 224, 224).CGColor;
                cell.ViewMain.Layer.BorderWidth = 1.0f;
                cell.ViewMain.Layer.MasksToBounds = true;
                cell.ViewMain.Layer.CornerRadius = 5;

                return cell;
            }
            else if (indexPath.Section == 1)
            {
                var cell = (SearchFilterPriceRangeCell)tableView.DequeueReusableCell(SearchFilterPriceRangeCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                return cell;
            }
            else if (indexPath.Section < 4)
            {
                var cell = (SearchFilterDropDownCell)tableView.DequeueReusableCell(SearchFilterDropDownCell.Key, indexPath);
                cell.LabelData.Text = labels[(int)indexPath.Section - 1];
                cell.LabelData.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.LabelData.TextColor = UIColor.LightGray;

                cell.ImageViewDropDown.Image = UIImage.FromBundle("next-arrrow-1");

                cell.ViewMain.Layer.BorderColor = UIColor.FromRGB(224, 224, 224).CGColor;
                cell.ViewMain.Layer.BorderWidth = 1.0f;
                cell.ViewMain.Layer.MasksToBounds = true;
                cell.ViewMain.Layer.CornerRadius = 5;

                return cell;
            }
            else if (indexPath.Section == 4)
            {
                var cell = (SearchFilterSwitchCell)tableView.DequeueReusableCell(SearchFilterSwitchCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.LabelFeatures.Text = labelFeatures[(int)indexPath.Row];
                cell.LabelFeatures.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.LabelFeatures.TextColor = UIColor.LightGray;

                return cell;
            }
            else
            {
                var cell = (SearchFilterResetApplyCell)tableView.DequeueReusableCell(SearchFilterResetApplyCell.Key, indexPath);
                cell.SelectionStyle = UITableViewCellSelectionStyle.None;
                cell.ButtonReset.BackgroundColor = UIColor.White;
                cell.ButtonReset.TitleLabel.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.ButtonReset.SetTitle("Reset", UIControlState.Normal);
                cell.ButtonReset.TitleLabel.TextColor = UIColor.FromRGB(52, 141, 155);
                cell.ButtonReset.Layer.BorderColor = UIColor.FromRGB(52, 141, 155).CGColor;
                cell.ButtonReset.Layer.BorderWidth = 1.0f;
                cell.ButtonReset.Layer.MasksToBounds = true;
                cell.ButtonReset.Layer.CornerRadius = 5;

                cell.ButtonApply.BackgroundColor = UIColor.FromRGB(52, 141, 155);
                cell.ButtonApply.Layer.CornerRadius = 5;
                cell.ButtonApply.TitleLabel.Font = UIFont.SystemFontOfSize(15, UIFontWeight.Regular);
                cell.ButtonApply.SetTitle("Apply", UIControlState.Normal);
                cell.ButtonApply.TitleLabel.TextColor = UIColor.White;
                cell.ButtonReset.Layer.BorderColor = UIColor.FromRGB(52, 141, 155).CGColor;
                cell.ButtonReset.Layer.BorderWidth = 1.0f;
                cell.ButtonReset.Layer.MasksToBounds = true;

                return cell;
            }
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            if (section == 4)
            {
                return labelFeatures.Count;
            }
            return 1;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 6;
        }

        public override UIView GetViewForHeader(UITableView tableView, nint section)
        {
            if (section <= 4)
            {
                UIView viewForHeader = new UIView(new CGRect(0, 0, (float)tableView.Bounds.Width, 40));
                viewForHeader.BackgroundColor = UIColor.White;

                UILabel label = new UILabel();
                label.TextColor = UIColor.Black;
                label.Font = UIFont.SystemFontOfSize(14, UIFontWeight.Regular);
                label.Frame = new System.Drawing.RectangleF(15, 0, (float)tableView.Bounds.Width - 30, 40);
                label.Text = sections[(int)section];
                viewForHeader.AddSubview(label);

                return viewForHeader;
                
            }
            else
            {
                UIView viewForHeader = new UIView(new CGRect(0, 0, 0,0));
                return viewForHeader;
            }
        }
    } 
}

