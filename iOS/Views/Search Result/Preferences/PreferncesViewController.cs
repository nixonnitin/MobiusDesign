using System;
using System.Collections.Generic;
using Foundation;
using UIKit;


namespace Mobius.iOS.Views
{
    public partial class PreferncesViewController : UIViewController
    {
        List<string> labels;
        List<string> labelData;

        public PreferncesViewController() : base("PreferncesViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            //labels = new List<string> { "British pound (GBP)", "Euro (EUR)", "United States Dollar (USD)" };

            LabelHotelPriceCurrency.TextColor = UIColor.Black;

            labels = new List<string> { "Price Display", "Currency" };
            labelData = new List<string> { "Price per night", "Dollars (USD)" };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewPreferences.RowHeight = UITableView.AutomaticDimension;
            TableViewPreferences.EstimatedRowHeight = 50;
            TableViewPreferences.RegisterNibForCellReuse(UINib.FromName("PreferencesCell", NSBundle.MainBundle), "PreferencesCell");
            TableViewPreferences.Source = new PreferencesSource(TableViewPreferences, labels,labelData);
        }
    }

    public class PreferencesSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> labelData;

        public PreferencesSource(UITableView table, List<string> labels, List<string> labelData)
        {
            this.table = table;
            this.labels = labels;
            this.labelData = labelData;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PreferencesCell)tableView.DequeueReusableCell(PreferencesCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            cell.LabelPreferences.Text = labels[indexPath.Row];
            cell.LabelPreferences.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Medium);
            cell.LabelPreferences.TextColor = UIColor.Black;

            cell.LabelData.Text = labelData[indexPath.Row];
            cell.LabelData.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Medium);
            cell.LabelData.TextColor = UIColor.LightGray;
                

            cell.ImageViewLast.Image = UIImage.FromBundle("next-arrrow-1");
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //Plus 1 for count of hotels cell
            return labels.Count;
        }


    }
}

