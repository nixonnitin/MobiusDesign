using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PreferencesSubPageViewController : UIViewController
    {
        List<string> labels;

        public PreferencesSubPageViewController() : base("PreferencesSubPageViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "British pound (GBP)", "Euro (EUR)", "United States Dollar (USD)" };

            initUI();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            TableViewPreferencesSubPage.RowHeight = UITableView.AutomaticDimension;
            TableViewPreferencesSubPage.EstimatedRowHeight = 50;
            TableViewPreferencesSubPage.RegisterNibForCellReuse(UINib.FromName("PreferencesCell", NSBundle.MainBundle), "PreferencesCell");
            TableViewPreferencesSubPage.Source = new PreferencesSubPageSource(TableViewPreferencesSubPage, labels);
        }
    }

    public class PreferencesSubPageSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;

        public PreferencesSubPageSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PreferencesCell)tableView.DequeueReusableCell(PreferencesCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            cell.LabelPreferences.Text = labels[indexPath.Row];
            cell.LabelPreferences.Font = UIFont.SystemFontOfSize(16, UIFontWeight.Medium);
            cell.LabelPreferences.TextColor = UIColor.Black;

            cell.LabelData.Hidden = true;
            cell.LabelData.Text = "";

            cell.ImageViewLast.Image = UIImage.FromBundle("check");
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //Plus 1 for count of hotels cell
            return labels.Count;
        }


    }
}

