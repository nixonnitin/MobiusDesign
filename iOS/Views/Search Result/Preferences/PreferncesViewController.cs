using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class PreferncesViewController : UIViewController
    {
        List<string> labels;

        public PreferncesViewController() : base("PreferncesViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            labels = new List<string> { "Hotel Location", "Dates", "Rooms" };
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        private void initUI()
        {
            //TableViewPreferences.RowHeight = UITableView.AutomaticDimension;
            //TableViewPreferences.EstimatedRowHeight = 64;
            TableViewPreferences.RegisterNibForCellReuse(UINib.FromName("PreferencesCell", NSBundle.MainBundle), "PreferencesCell");
            TableViewPreferences.Source = new PreferencesSource(TableViewPreferences, labels);
        }
    }

    public class PreferencesSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
       

        public PreferencesSource(UITableView table, List<string> labels)
        {
            this.table = table;
            this.labels = labels;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (PreferencesCell)tableView.DequeueReusableCell(PreferencesCell.Key, indexPath);
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;
            //cell.LabelPreferences.Text = labels[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            //Plus 1 for count of hotels cell
            return 3;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 60;
        }
    }
}

