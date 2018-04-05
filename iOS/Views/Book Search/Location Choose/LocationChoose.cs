using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace Mobius.iOS.Views
{
    public partial class LocationChoose : UIViewController
    {
        List<string> labels;
        List<string> section;

        public LocationChoose() : base("LocationChoose", null)
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
            labels = new List<string> { "Hotel Location", "Dates", "Rooms" };
            section = new List<string> { "Hotels", "Locations", "Regions" };
        }

        private void initUI()
        {
            TableViewLocation.RowHeight = UITableView.AutomaticDimension;
            TableViewLocation.EstimatedRowHeight = 60;
            TableViewLocation.RegisterNibForCellReuse(UINib.FromName("LocationChooseCell", NSBundle.MainBundle), "LocationChooseCell");
            TableViewLocation.Source = new LocationChooseSource(TableViewLocation, labels, section);
        }
    }

    public class LocationChooseSource : UITableViewSource
    {
        UITableView table;
        List<string> labels;
        List<string> sections;

        public LocationChooseSource(UITableView table, List<string> labels, List<string> section)
        {
            this.table = table;
            this.labels = labels;
            this.sections = section;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (LocationChooseCell)tableView.DequeueReusableCell(LocationChooseCell.Key, indexPath);
            cell.LabelLocation.Text = labels[indexPath.Row];;

            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return labels.Count ;
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return sections.Count;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            var titleHeader = sections[(int)section];
            return titleHeader;//base.TitleForHeader(tableView, section);
        }
    }
}

